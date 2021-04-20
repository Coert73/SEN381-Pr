using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public abstract class Calls
    {
        private BusinessClient _client;
        private DateTime _callLogging;
        private Service _serviceType;
        private string _clientRequest;

        public abstract BusinessClient Client { get; set ; }
        public abstract DateTime CallLogging { get; set; }
        public abstract Service ServiceType { get; set; }
        public abstract string ClientRequest { get; set; }
    }
}