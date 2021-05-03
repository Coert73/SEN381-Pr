using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Jobs
    public abstract class Jobs
    {
        protected Jobs(string jobId, string addressId, string referenceNumber, int escalationLevel, string assignedTechnician, string contractId)
        {
            JobId = jobId;
            AddressId = addressId;
            ReferenceNumber = referenceNumber;
            EscalationLevel = escalationLevel;
            AssignedTechnician = assignedTechnician;
            ContractId = contractId;
        }

        public string JobId { get; set; }
        public string AddressId { get; set; }
        public string ReferenceNumber { get; set; }
        public int EscalationLevel { get; set; }
        public string AssignedTechnician { get; set; }
        public string ContractId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Jobs jobs &&
                   JobId == jobs.JobId &&
                   AddressId == jobs.AddressId &&
                   ReferenceNumber == jobs.ReferenceNumber &&
                   EscalationLevel == jobs.EscalationLevel &&
                   AssignedTechnician == jobs.AssignedTechnician &&
                   ContractId == jobs.ContractId;
        }

        public override int GetHashCode()
        {
            int hashCode = -1701320387;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JobId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AddressId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceNumber);
            hashCode = hashCode * -1521134295 + EscalationLevel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AssignedTechnician);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractId);
            return hashCode;
        }
    }
    #endregion
}