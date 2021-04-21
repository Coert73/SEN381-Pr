using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ReportADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Reports");
        }

        public DataSet SortReportData()
        {
            return Controller.CarryCommand($"SELECT * FROM Reports ORDER BY ReferenceNumber DESC");
        }

        public DataSet SearchReport(int reference)
        {
            return Controller.CarryCommand($"SELECT * FROM Reports WHERE ReferenceNumber = {reference}");
        }
    }
}
