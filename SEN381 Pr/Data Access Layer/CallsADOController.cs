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


        public int CountCalls()
        {
            return Controller.CarryCommand("SELECT * FROM Calls").Tables[0].Rows.Count;
        }

        public DataSet InsertData(Call call)
        {
            return Controller.CarryCommand($"INSERT INTO Calls (CallId,ClientId,ContractId,InOut,Duration,Date) VALUES ('{call.CallId}','{call.ClientId}','{call.ContractId}','{call.InOut}','{call.Duration}','{call.date}')");
        }
    }
}
