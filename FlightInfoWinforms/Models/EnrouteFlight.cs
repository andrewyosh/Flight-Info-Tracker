using System;
using System.Collections.Generic;
using System.Text;

namespace FlightInfoWinforms
{
    public class EnrouteFlight
    {
        public int actualdeparturetime { get; set; }
        public string aircrafttype { get; set; }
        public string destination { get; set; }
        public string destinationCity { get; set; }
        public string destinationName { get; set; }
        public int estimatedarrivaltime { get; set; }
        public int filed_departuretime { get; set; }
        public string ident { get; set; }
        public string origin { get; set; }
        public string originCity { get; set; }
        public string originName { get; set; }
    }
    public class Enroutes
    {
        public List<EnrouteFlight> enroute { get; set; }
        public int next_offset { get; set; }
    }
    public class EnrouteResults
    {
        public Enroutes EnrouteResult { get; set; }
    }
}

