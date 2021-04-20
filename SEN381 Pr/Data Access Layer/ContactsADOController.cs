using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ContactsADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Contract");
        }

        public DataSet InsertContract()
        {
            return Controller.CarryCommand($"");
        }

        public DataSet DeleteContract()
        {
            return Controller.CarryCommand($"");
        }

        public DataSet UpdateContract()
        {
            return Controller.CarryCommand($"");
        }
    }
}
