using System;
using System.Collections.Generic;
using System.Text;

namespace FlightInfoWinforms.Views
{
    public interface IFlightInfoView
    {
        IList<ArrivalFlight> ArrivalData {get;set;}
        IList<DepartureFlight> DepartureData { get; set; }
        IList<EnrouteFlight> EnrouteData { get; set; }
        string arrivalStatus { get; set; }
        string departureStatus { get; set; }
        string enrouteStatus { get; set; }
        Presenters.FlightInfoPresenter Presenter { set; }
        public void ShowMessage(string message);
    }
}
