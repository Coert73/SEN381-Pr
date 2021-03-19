using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class ReportHandler
    {
        private string _referenceNumber;
        private BusinessClient _client;
        private Job _job;

        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public BusinessClient Client { get => _client; set => _client = value; }
        public Job Job { get => _job; set => _job = value; }

        public BusinessClient BusinessClient
        {
            get => default;
            set
            {
            }
        }

        public Job Job1
        {
            get => default;
            set
            {
            }
        }

        public void GenerateReport()
        {

        }
    }
}