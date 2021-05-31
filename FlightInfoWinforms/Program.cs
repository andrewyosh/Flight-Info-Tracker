using FlightInfoWinforms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightInfoWinforms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();            
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new FlightInfoView();
            var presenter = new Presenters.FlightInfoPresenter(view);
            Application.Run(view);
        }
    }
}
