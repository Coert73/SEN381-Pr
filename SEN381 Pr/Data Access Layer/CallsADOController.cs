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

        public DataSet InsertData(int clientid,int contractid,string callduration, string calldate)
        {
            return Controller.CarryCommand($"INSERT INTO Calls (ClientId,ContractId,Duration,Date) VALUES ({clientid},{contractid},'{callduration}','{calldate}')");
        }

    }
}
