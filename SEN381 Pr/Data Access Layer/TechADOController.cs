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

        public DataSet InsertTechnician(Technician tech)
        {
            return Controller.CarryCommand($"INSERT INTO Technition (Name,Surname,Number) VALUES ('{tech.Name}','{tech.Surname}',{tech.Number})");
        }

        public DataSet DeleteTechnician(int id)
        {
            return Controller.CarryCommand($"DELETE FROM Technition WHERE TechID = {id}");
        }

        public DataSet UpdateTechnician(Technician tech,int id)
        {
            return Controller.CarryCommand($"UPDATE Technition SET Name='{tech.Name}',Surname='{tech.Surname}',Number='{tech.Number}' WHERE TechID = {id}");
        }
    }
}
