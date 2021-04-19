using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ClientADOController
    {
        ADOController Controller = new ADOController();
        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Client");
        }

        public DataSet InsertClient()
        {
            return Controller.CarryCommand($"");
        }

        public DataSet DeleteClient()
        {
            return Controller.CarryCommand($"DELETE FROM  WHERE ={}");
        }

        public DataSet UpdateClient()
        {
            return Controller.CarryCommand($"UPDATE  SET  WHERE = {id}");
        }

    }
}
