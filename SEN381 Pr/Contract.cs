using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Contract
    {
        private string _contractName;
        private string _contractType;
        private List<Service> _contractService;
        public string ContractName { get => _contractName; set => _contractName = value; }
        public string ContractType { get => _contractType; set => _contractType = value; }
        public List<Service> ContractService { get => _contractService; set => _contractService = value; }

        public Service Service
        {
            get => default;
            set
            {
            }
        }
    }
}