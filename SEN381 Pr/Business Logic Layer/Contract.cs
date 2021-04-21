using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Contract
    public class Contract
    {
        #region Constructor
        private string _contractName;
        private string _contractType;
        private List<Service> _contractService;
        private List<Package> _packages;

        public Contract(string contractName, string contractType, List<Service> contractService, List<Package> packages)
        {
            _contractName = contractName;
            _contractType = contractType;
            _contractService = contractService;
            _packages = packages;
        }

        public string ContractName { get => _contractName; set => _contractName = value; }
        public string ContractType { get => _contractType; set => _contractType = value; }
        public List<Service> ContractService { get => _contractService; set => _contractService = value; }
        public List<Package> Packages { get => _packages; set => _packages = value; }

        #endregion
        public Client Client
        {
            get => default;
            set
            {
            }
        }
        #region Methods

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Contract contract &&
                   _contractName == contract._contractName &&
                   _contractType == contract._contractType &&
                   EqualityComparer<List<Service>>.Default.Equals(_contractService, contract._contractService) &&
                   EqualityComparer<List<Package>>.Default.Equals(_packages, contract._packages);
        }
        #endregion
        #region GetHashCode
        public override int GetHashCode()
        {
            int hashCode = 1030794865;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_contractName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_contractType);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Service>>.Default.GetHashCode(_contractService);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Package>>.Default.GetHashCode(_packages);
            return hashCode;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return "Contract: " + ContractName + " " + ContractType + " " + ContractService;
        }
        #endregion
        #endregion
    }
    #endregion
}