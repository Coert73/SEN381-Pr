using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Request
    {
        private string _referenceNumber;
        private bool _requestAppropriation;
        private Job _requestJob;

        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public bool RequestAppropriation { get => _requestAppropriation; set => _requestAppropriation = value; }
        public Job RequestJob { get => _requestJob; set => _requestJob = value; }

        public Job Job
        {
            get => default;
            set
            {
            }
        }
    }
}