using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class BusinessADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadBusiness()
        {
            return Controller.CarryCommand("SELECT * FROM Business");
        }

        public DataSet InsertBusiness(BusinessClient Business)
        {
            return Controller.CarryCommand($"INSERT INTO Business (BusinessId,BusinessName) VALUES ('{Business.BusinessID}','{Business.BusinessName}')");
        }

        public DataSet DeleteBusiness(BusinessClient Business)
        {
            return Controller.CarryCommand($"DELETE FROM Business WHERE BusinessId = '{Business.BusinessID}'");
        }

        public DataSet UpdateBusiness(BusinessClient Business)
        {
            return Controller.CarryCommand($"UPDATE Business SET BusinessName = '{Business.BusinessName}' WHERE BusinessId = '{Business.BusinessID}'");
        }

        public int CountBusiness()
        {
            return Controller.CarryCommand("SELECT * FROM Business").Tables[0].Rows.Count;
        }
    }
}
