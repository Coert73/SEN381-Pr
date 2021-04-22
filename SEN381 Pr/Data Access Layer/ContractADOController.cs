using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ContractADOController
    {

        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Contract");
        }

        public DataSet InsertContract(Contract con)
        {
            return Controller.CarryCommand($"INSERT INTO Conctract (ContractId,PackageId,ContractName,ContractType,ContractLeaseStart,ContractLeaseEnd,ContractStatus,ContractServiceLevel) VALUES ()");
        }

        public DataSet DeleteContract(Contract con)
        {
            return Controller.CarryCommand($"DELETE FROM Contract WHERE ContractId = '{con.ContractId}'");
        }

        public DataSet UpdateContract(Contract con)
        {
            return Controller.CarryCommand($"UPDATE Contract SET");
        }

        public int CountContract()
        {
            return Controller.CarryCommand("SELECT * FROM Contract").Tables[0].Rows.Count;
        }

    }
}
