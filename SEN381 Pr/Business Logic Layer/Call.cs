using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Call
    public class Call : Calls
    {
        public Call(string callId, string clientId, string contractId, byte inOut, string duration, DateTime date) : base(callId, clientId, contractId, inOut, duration, date)
        {
            this.CallId = callId;
            this.ClientId = clientId;
            this.ContractId = contractId;
            this.InOut = inOut;
            this.Duration = duration;
            this.date = date;
        }
    }
    #endregion
}