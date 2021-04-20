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

        public DataSet SortData(string sort)
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
