using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightInfoWinforms.Views
{
    public partial class FlightInfoView : Form, IFlightInfoView
    {
        public FlightInfoView()
        {
            InitializeComponent();
        }
        public void ShowMessage(string message) 
        {
            MessageBox.Show(message);
        }
        public IList<ArrivalFlight> ArrivalData 
        {
            get { return (IList<ArrivalFlight>)ArrivalsGridView.DataSource; }
            set {ArrivalsGridView.DataSource = value; }
        }
        public IList<DepartureFlight> DepartureData
        {
            get { return (IList<DepartureFlight>)DeparturesGridView.DataSource; }
            set { DeparturesGridView.DataSource = value; }
        }
        public IList<EnrouteFlight> EnrouteData
        {
            get { return (IList<EnrouteFlight>)EnroutesGridView.DataSource; }
            set { EnroutesGridView.DataSource = value; }
        }
        public string arrivalStatus 
        {
            get { return arrivalStatusLabel.Text; }
            set { arrivalStatusLabel.Text = "Status: " + value; }
        }
        public string departureStatus
        {
            get { return departureStatusLabel.Text; }
            set { departureStatusLabel.Text = "Status: " + value; }
        }
        public string enrouteStatus
        {
            get { return enrouteStatusLabel.Text; }
            set { enrouteStatusLabel.Text = "Status: " + value; }
        }
        public Presenters.FlightInfoPresenter Presenter { private get; set; }

        private async void PollBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PollBox.Checked)
            {
                await Presenter.GetData();
            }
            else 
            {
                Presenter.CancelTask();
            }
        }
    }
}
