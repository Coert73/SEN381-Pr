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
            return Controller.CarryCommand("SELECT * FROM Technician");
        }

        public DataSet InsertTechnician(Technician tech)
        {

            return Controller.CarryCommand($"INSERT INTO Technician (TechID,TechName,Surname,Number) VALUES ('{tech.ID}','{tech.Name}','{tech.Surname}','{tech.Number}')");
        }

        public DataSet DeleteTechnician(Technician tech)
        {
            return Controller.CarryCommand($"DELETE FROM Technician WHERE TechID = '{tech.ID}'");
        }

        public DataSet UpdateTechnician(Technician tech)
        {
            return Controller.CarryCommand($"UPDATE Technician SET TechName='{tech.Name}',Surname='{tech.Surname}',Number='{tech.Number}' WHERE TechID = '{tech.ID}'");
        }

        public int CountTechs()
        {
            return Controller.CarryCommand("SELECT * FROM Technician").Tables[0].Rows.Count;
        }
    }
}
