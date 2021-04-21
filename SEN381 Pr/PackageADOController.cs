using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class PackageADOController
    {
        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Packages");
        }

        public DataSet InsertPackage(Package pack)
        {
            return Controller.CarryCommand($"INSERT INTO Packages () VALUES ()");
        }

        public DataSet DeletePackage(Package pack)
        {
            return Controller.CarryCommand($"DELETE FROM Packages WHERE ");
        }

        public DataSet UpdatePackage(Package pack)
        {
            return Controller.CarryCommand($"UPDATE Packages SET");
        }

        public int CountPackages()
        {
            return Controller.CarryCommand("SELECT * FROM Packges").Tables[0].Rows.Count;
        }
    }
}
