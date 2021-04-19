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

        public DataSet InsertTechnician(string name,string surname, string number)
        {
            return Controller.CarryCommand($"INSERT INTO Technition (Name,Surname,Number) VALUES ('{name}','{surname}',{number})");
        }

        public DataSet DeleteTechnician(string id)
        {
            return Controller.CarryCommand($"DELETE FROM Technition WHERE TechID = {id}");
        }

        public DataSet UpdateTechnician(string name,string surname,string number,string id)
        {
            return Controller.CarryCommand($"UPDATE Technition SET Name={name},Surname={surname},Number={number} WHERE TechID = {id}");
        }
    }
}
