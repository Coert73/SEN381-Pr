using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Calls
    public abstract class Calls
    {
        public Calls(string callId, string clientId, string contractId, byte inOut, string duration, string date)
        {
            CallId = callId;
            ClientId = clientId;
            ContractId = contractId;
            InOut = inOut;
            Duration = duration;
            this.date = date;
        }

        public string CallId { get; set; }
        public string ClientId { get; set ; }
        public string ContractId { get; set; }
        public byte InOut { get; set; }
        public string Duration { get; set; }
        public string date { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Calls calls &&
                   CallId == calls.CallId &&
                   ClientId == calls.ClientId &&
                   ContractId == calls.ContractId &&
                   InOut == calls.InOut &&
                   Duration == calls.Duration &&
                   date == calls.date;
        }

        public override int GetHashCode()
        {
            int hashCode = 1769408317;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CallId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractId);
            hashCode = hashCode * -1521134295 + InOut.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Duration);
            hashCode = hashCode * -1521134295 + date.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    #endregion
}