using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class Reports
    {
        private string _reportId;
        private string _referenceNumber;
        private string _jobId;
        private string _clientId;
        private DateTime _date;

        public Reports(string reportId, string referenceNumber, string jobId, string clientId, DateTime date)
        {
            ReportId = reportId;
            ReferenceNumber = referenceNumber;
            JobId = jobId;
            ClientId = clientId;
            Date = date;
        }

        public string ReportId { get => _reportId; set => _reportId = value; }
        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public string JobId { get => _jobId; set => _jobId = value; }
        public string ClientId { get => _clientId; set => _clientId = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public override bool Equals(object obj)
        {
            return obj is Reports reports &&
                   _reportId == reports._reportId &&
                   _referenceNumber == reports._referenceNumber &&
                   _jobId == reports._jobId &&
                   _clientId == reports._clientId &&
                   _date == reports._date;
        }

        public override int GetHashCode()
        {
            int hashCode = 1144799233;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_reportId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_referenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_jobId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_clientId);
            hashCode = hashCode * -1521134295 + _date.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
