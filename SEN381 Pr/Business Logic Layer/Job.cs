using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Job
    public class Job : Jobs
    {
        public Job(string jobId, string addressId, string referenceNumber, int escalationLevel, string assignedTechnician, string contractId) : base(jobId, addressId, referenceNumber, escalationLevel, assignedTechnician, contractId)
        {
            this.JobId = jobId ;
            this.AddressId = addressId;
            this.ReferenceNumber = referenceNumber;
            this.EscalationLevel = escalationLevel;
            this.AssignedTechnician = assignedTechnician;
            this.ContractId = contractId;            
        }
    }
    #endregion
}