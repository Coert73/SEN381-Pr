using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class TechADOController
    {

        //Technician specific ADO controller... Can only handle technician queries...

        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Technition");
        }

        public DataSet InsertTechnician()
        {
            return Controller.CarryCommand("SELECT * FROM Technition");
        }
    }
}
