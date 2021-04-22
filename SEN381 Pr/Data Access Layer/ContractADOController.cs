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
            return Controller.CarryCommand($"INSERT INTO Contract (ContractId,PackageId,ContractName,ContractType,ContractLeaseStart,ContractLeaseEnd,ContractStatus,ContractServiceLevel) VALUES ('{con.ContractId}','{con.PackageId}','{con.ContractName}','{con.ContractType}','{con.Start}','{con.End}',{Convert.ToByte(con.Status)},'{con.Servicelevel}')");
              
        }

        public DataSet DeleteContract(Contract con)
        {
            return Controller.CarryCommand($"DELETE FROM Contract WHERE ContractId = '{con.ContractId}'");
        }

        public DataSet UpdateContract(Contract con)
        {
            return Controller.CarryCommand($"UPDATE Contract SET PackageId = '{con.PackageId}',ContractName = '{con.ContractName}',ContractType = '{con.ContractType}',ContractLeaseStart = '{con.Start}',ContractLeaseEnd = '{con.End}',ContractStatus= {Convert.ToByte(con.Status)},ContractServiceLevel = '{con.Servicelevel}' WHERE ContractId = '{con.ContractId}'");
        }

        public int CountContract()
        {
            return Controller.CarryCommand("SELECT * FROM Contract").Tables[0].Rows.Count;
        }

    }
}
