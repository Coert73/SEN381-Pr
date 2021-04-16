using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ADOMethodController
    {

        //Business Logic Layer part of the data passing thru...

        TechADOController TechCon = new TechADOController();

        public DataSet LoadData()
        {
            return TechCon.LoadData();
        }

        public DataSet InsertData()
        {
            return TechCon.InsertTechnician();
        }




    }
}
