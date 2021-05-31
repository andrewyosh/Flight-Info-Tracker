using FlightInfoWinforms.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web;

namespace FlightInfoWinforms.Presenters
{
    public class FlightInfoPresenter
    {
        private readonly IFlightInfoView _view;
        private HttpClient _client;
        private CancellationTokenSource _cts;
        private int _pollTime;
        private System.Random _random;
        private string _apiKey;

        //constructor dependency injection 
        public FlightInfoPresenter(IFlightInfoView view)
        {
            _view = view;
            view.Presenter = this;

            _cts = new CancellationTokenSource();

            _pollTime = 10000;

            _random = new System.Random();

            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://flightxml.flightaware.com/json/FlightXML2/");
            _apiKey = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Api_key.txt");
            var credentials = Encoding.ASCII.GetBytes(_apiKey);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
        }

        public async Task GetData()
        {
            while (true)
            {
                //Check if task should be cancelled
                if (_cts.IsCancellationRequested)
                {
                    _view.ShowMessage("Polling aborted");
                    _cts = new CancellationTokenSource();
                    break;
                }

                var arrivedResultsTask = GetFlightInfoAsync("Arrived", "ATL", "10", "ga", "0");
                var departedResultsTask = GetFlightInfoAsync("Departed", "ATL", "10", "ga", "0");
                var enrouteResultsTask = GetFlightInfoAsync("Enroute", "ATL", "10", "ga", "0");

                //Check when any task is finished and display results on view
                var flightResultsTasks = new List<Task> { arrivedResultsTask, departedResultsTask, enrouteResultsTask };
                while (flightResultsTasks.Count > 0)
                {
                    Task finishedTask = await Task.WhenAny(flightResultsTasks);
                    if (finishedTask == arrivedResultsTask)
                    {
                        string arrivedResultsContent = await arrivedResultsTask;
                        ArrivedResults arrivedResults = JsonConvert.DeserializeObject<ArrivedResults>(arrivedResultsContent);
                        _view.ArrivalData = arrivedResults.ArrivedResult.arrivals;
                    }
                    else if (finishedTask == departedResultsTask)
                    {
                        string departedResultsContent = await departedResultsTask;
                        DepartedResults departedResults = JsonConvert.DeserializeObject<DepartedResults>(departedResultsContent);
                        _view.DepartureData = departedResults.DepartedResult.departures;
                    }
                    else
                    {
                        string enrouteResultsContent = await enrouteResultsTask;
                        EnrouteResults enrouteResults = JsonConvert.DeserializeObject<EnrouteResults>(enrouteResultsContent);
                        _view.EnrouteData = enrouteResults.EnrouteResult.enroute;
                    }
                    flightResultsTasks.Remove(finishedTask);
                }
                _view.ShowMessage("All Results Ready! Re-polling in " + _pollTime / 1000 + " seconds...");
                //Wait specified time, cancel if requested
                try
                {
                    await Task.Delay(_pollTime, _cts.Token);
                }
                catch
                {
                    _view.ShowMessage("Polling aborted");
                    _cts = new CancellationTokenSource();
                    break;
                }
            }
        }
        public void CancelTask()
        {
            _cts.Cancel();
        }
        private async Task<string> GetFlightInfoAsync(string infoType, string airport, string howMany, string filter, string offset)
        {

            // Build uri based on input parameters
            UriBuilder builder = new UriBuilder(_client.BaseAddress.ToString() + infoType);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["airport"] = airport;
            query["howMany"] = howMany;
            query["filter"] = filter;
            query["offset"] = offset;
            builder.Query = query.ToString();

            //Set action to update the different possible statuses (arrived, departed, enroute)
            Action<string> UpdateStatus;
            if (infoType == "Arrived")
            {
                UpdateStatus = status => _view.arrivalStatus = status;
            }
            else if (infoType == "Departed")
            {
                UpdateStatus = status => _view.departureStatus = status;
            }
            else
            {
                UpdateStatus = status => _view.enrouteStatus = status;
            }

            string content = "";
            UpdateStatus("Sending request for " + infoType + " data");
            await Task.Delay(_random.Next(0, 2000)); //artificial delay                
            //Request response from API
            HttpResponseMessage response = await _client.GetAsync(builder.Uri.ToString());
            UpdateStatus("Response for " + infoType + " received");
            if (response.IsSuccessStatusCode)
            {
                UpdateStatus("Reading " + infoType + " data");
                await Task.Delay(_random.Next(0, 2000)); //artificial delay                
                //Read response content
                content = await response.Content.ReadAsStringAsync();
                UpdateStatus("Done!");
            }
            return content;
        }

    }
}
