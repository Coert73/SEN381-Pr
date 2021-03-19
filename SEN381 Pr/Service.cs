using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Service : Services
    {
        public override string ServiceName { get { return ServiceName; } set { ServiceName = value; } }
        public override string ServiceDescription { get { return ServiceDescription; } set { ServiceDescription = value; } }
        public override int ServiceDuration { get { return ServiceDuration; } set { ServiceDuration = value; } }
        public override string ServiceAgreement { get { return ServiceAgreement; } set { ServiceAgreement = value; } }
        public override int ServiceLevel { get { return ServiceLevel; } set { ServiceLevel = value; } }
    }
}