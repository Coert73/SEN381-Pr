using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return Controller.CarryCommand($"INSERT INTO Packages (PackageId,PackageName,PackageType,ServiceId1,ServiceId2,ServiceId3,ServiceId4,ServiceId5,ServiceId6,ServiceId7,ServiceId8,ServiceId9,ServiceId10,ServiceId11,ServiceId12) VALUES ('{pack.Id}','{pack.Name}','{pack.Type}','{pack.Services[0]}','{pack.Services[1]}','{pack.Services[2]}','{pack.Services[3]}','{pack.Services[4]}','{pack.Services[5]}','{pack.Services[6]}','{pack.Services[7]}','{pack.Services[8]}','{pack.Services[9]}','{pack.Services[10]}','{pack.Services[11]}')");       
        }

        public DataSet DeletePackage(Package pack)
        {
            return Controller.CarryCommand($"DELETE FROM Packages WHERE PackageId = '{pack.Id}'");
        }

        public DataSet UpdatePackage(Package pack)
        {
            return Controller.CarryCommand($"UPDATE Packages SET PackageName = '{pack.Name}',PackageType = '{pack.Type}',ServiceId1 = '{pack.Services[0]}',ServiceId2 = '{pack.Services[1]}',ServiceId3 = '{pack.Services[2]}',ServiceId4 = '{pack.Services[3]}',ServiceId5 = '{pack.Services[4]}',ServiceId6 = '{pack.Services[5]}',ServiceId7 = '{pack.Services[6]}',ServiceId8 = '{pack.Services[7]}',ServiceId9 = '{pack.Services[8]}',ServiceId10 = '{pack.Services[9]}',ServiceId11 = '{pack.Services[10]}',ServiceId12 = '{pack.Services[11]}' WHERE PackageId = '{pack.Id}'");
        }

        public int CountPackages()
        {
            return Controller.CarryCommand("SELECT * FROM Packages").Tables[0].Rows.Count;
        }
    }
}
