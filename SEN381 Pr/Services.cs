using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public abstract class Services
    {
        private string _serviceName;
        private string _serviceDescription;
        private int _serviceDuration;
        private string _serviceAgreement;
        private int _serviceLevel;

        public abstract string ServiceName { get; set; }
        public abstract string ServiceDescription { get; set; }
        public abstract int ServiceDuration { get; set; }
        public abstract string ServiceAgreement { get; set; }
        public abstract int ServiceLevel { get; set; }
    }
}