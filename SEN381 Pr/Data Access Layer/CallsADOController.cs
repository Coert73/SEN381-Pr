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

        public DataSet InsertData(Call calls)
        {
            return Controller.CarryCommand($"INSERT INTO Calls (CallId,ClientId,ContractId,InOut,Duration,Date) VALUES ('{calls.CallId}','{calls.ClientId}','{calls.ContractId}','{calls.InOut}','{calls.Duration}','{calls.date}')");
        }

        public int CountCalls()
        {
            return Controller.CarryCommand("SELECT * FROM Calls").Tables[0].Rows.Count;
        }
    }
}
