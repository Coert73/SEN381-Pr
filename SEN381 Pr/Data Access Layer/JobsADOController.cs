using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class JobsADOController
    {

        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Jobs");
        }

        public DataSet InsertJob(string name, string surname, string number)
        {
            return Controller.CarryCommand($"");
        }

        public DataSet DeleteJob(string id)
        {
            return Controller.CarryCommand($"");
        }

        public DataSet UpdateJob(string name, string surname, string number, string id)
        {
            return Controller.CarryCommand($"");
        }
    }
}
