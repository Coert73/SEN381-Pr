using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class CallsADOController
    {

        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Calls");
        }

        public DataSet InsertData(string callid,string clientid,string contractid,byte inout,string callduration, string calldate)
        {
            return Controller.CarryCommand($"INSERT INTO Calls (CallId,ClientId,ContractId,InOut,Duration,Date) VALUES ('{callid}','{clientid}','{contractid}','{inout}','{callduration}','{calldate}')");
        }
    }
}
