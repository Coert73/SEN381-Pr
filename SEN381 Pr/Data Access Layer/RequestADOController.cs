using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class RequestADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand($"SELECT * FROM Requests");
        }

        public DataSet InsertRequest(Request req)
        {
            return Controller.CarryCommand($"INSERT INTO Requests (ReferenceNumber,ClientId,CallId,Approval,ReqStatus) VALUES ('{req.ReferenceNumber}','{req.ClientId}','{req.CallId}',{req.Approval},'{req.ReqStatus}')");
        }

        public DataSet DeleteRequest(Request req)
        {
            return Controller.CarryCommand($"");
        }

        public DataSet UpdateRequest(Request req)
        {
            return Controller.CarryCommand($"");
        }

        public int CountRequest()
        {
            return Controller.CarryCommand("SELECT * FROM Requests").Tables[0].Rows.Count;
        }


        public DataSet SortRequestData(string sort)
        {

            DataSet set = new DataSet();

            switch (sort)
            {
                case "Reference Number":
                    set =  Controller.CarryCommand($"SELECT * FROM Requests ORDER BY ReferenceNumber DESC");
                    break;
                case "Client":
                    set =  Controller.CarryCommand($"SELECT * FROM Requests ORDER BY ClientID DESC");
                    break;
                case "Approval":
                    set = Controller.CarryCommand($"SELECT * FROM Requests ORDER BY Approval DESC");
                    break;
            }

            return set;
        }
    }
}
