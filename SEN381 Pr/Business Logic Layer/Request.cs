using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Request
    public class Request
    {      
        private string _referenceNumber;
        private string _clientId;
        private string _callId;
        private byte _approval;
        private char _reqStatus;

        public Request(string referenceNumber, string clientId, string callId, byte approval, char reqStatus)
        {
            ReferenceNumber = referenceNumber;
            ClientId = clientId;
            CallId = callId;
            Approval = approval;
            ReqStatus = reqStatus;
        }

        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public string ClientId { get => _clientId; set => _clientId = value; }
        public string CallId { get => _callId; set => _callId = value; }
        public byte Approval { get => _approval; set => _approval = value; }
        public char ReqStatus { get => _reqStatus; set => _reqStatus = value; }

        public override bool Equals(object obj)
        {
            return obj is Request request &&
                   _referenceNumber == request._referenceNumber &&
                   _clientId == request._clientId &&
                   _callId == request._callId &&
                   _approval == request._approval &&
                   _reqStatus == request._reqStatus;
        }

        public override int GetHashCode()
        {
            int hashCode = 256465958;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_referenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_clientId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_callId);
            hashCode = hashCode * -1521134295 + _approval.GetHashCode();
            hashCode = hashCode * -1521134295 + _reqStatus.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    #endregion
}