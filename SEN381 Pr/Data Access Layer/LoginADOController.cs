using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class LoginADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData(string username)
        {
            return Controller.CarryCommand($"SELECT * FROM Users WHERE UserName = '{username}'");
        }
    }
}
