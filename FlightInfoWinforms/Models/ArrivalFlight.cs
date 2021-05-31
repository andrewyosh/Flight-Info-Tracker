using System;
using System.Collections.Generic;
using System.Text;

namespace FlightInfoWinforms
{
    public class ArrivalFlight
    {
        public int actualarrivaltime { get; set; }
        public int actualdeparturetime { get; set; }
        public string aircrafttype { get;set;}
        public string destination { get; set; }
        public string destinationCity { get; set; }
        public string destinationName { get; set; }
        public string ident { get; set; }
        public string origin { get; set; }
        public string originCity { get; set; }
        public string originName { get; set; }
    }
    public class Arrivals
    {
        public List<ArrivalFlight> arrivals { get; set;}
        public int next_offset { get; set; }
    }
    public class ArrivedResults
    {
        public Arrivals ArrivedResult { get; set; }
    }
}
