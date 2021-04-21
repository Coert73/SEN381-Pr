using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Contract
    {
        private string _contractId;
        private string _packageId;
        private string _contractName;
        private string _contractType;
        private string _start;
        private string _end;
        private bool _status;
        private char _servicelevel;

        public Contract(string contractId, string packageId, string contractName, string contractType, string start, string end, bool status, char servicelevel)
        {
            ContractId = contractId;
            PackageId = packageId;
            ContractName = contractName;
            ContractType = contractType;
            Start = start;
            End = end;
            Status = status;
            Servicelevel = servicelevel;
        }

        public string ContractId { get => _contractId; set => _contractId = value; }
        public string PackageId { get => _packageId; set => _packageId = value; }
        public string ContractName { get => _contractName; set => _contractName = value; }
        public string ContractType { get => _contractType; set => _contractType = value; }
        public string Start { get => _start; set => _start = value; }
        public string End { get => _end; set => _end = value; }
        public bool Status { get => _status; set => _status = value; }
        public char Servicelevel { get => _servicelevel; set => _servicelevel = value; }

        public override bool Equals(object obj)
        {
            return obj is Contract contract &&
                   _contractId == contract._contractId &&
                   _packageId == contract._packageId &&
                   _contractName == contract._contractName &&
                   _contractType == contract._contractType &&
                   _start == contract._start &&
                   _end == contract._end &&
                   _status == contract._status &&
                   _servicelevel == contract._servicelevel &&
                   ContractId == contract.ContractId &&
                   PackageId == contract.PackageId &&
                   ContractName == contract.ContractName &&
                   ContractType == contract.ContractType &&
                   Start == contract.Start &&
                   End == contract.End &&
                   Status == contract.Status &&
                   Servicelevel == contract.Servicelevel;
        }

        public override int GetHashCode()
        {
            int hashCode = -126832290;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_contractId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_packageId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_contractName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_contractType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_start);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_end);
            hashCode = hashCode * -1521134295 + _status.GetHashCode();
            hashCode = hashCode * -1521134295 + _servicelevel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PackageId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Start);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(End);
            hashCode = hashCode * -1521134295 + Status.GetHashCode();
            hashCode = hashCode * -1521134295 + Servicelevel.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}