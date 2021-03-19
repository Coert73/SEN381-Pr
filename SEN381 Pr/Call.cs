using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Call : Calls
    {
        public override BusinessClient Client { get => Client; set => Client = value; }
        public override DateTime CallLogging { get => CallLogging; set => CallLogging = value; }
        public override Service ServiceType { get => ServiceType; set => ServiceType = value; }
        public override string ClientRequest { get => ClientRequest; set => ClientRequest = value; }

        public CallHandler CallHandler
        {
            get => default;
            set
            {
            }
        }
    }
}