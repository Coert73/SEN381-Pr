using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class ClientADOController
    {
        ADOController Controller = new ADOController();
        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Client");
        }

        public DataSet InsertClient(int busid,int conid,string name, string surname, string number, string callsmade, string pos)
        {
            return Controller.CarryCommand($"INSERT INTO Client (BusinessId,ContractId,Name,Surname,Number,CallsMade,Position) VALUES ({busid},{conid},'{name}','{surname}','{number}','{callsmade}','{pos}')");
        }

        public DataSet DeleteClient(int id)
        {
            return Controller.CarryCommand($"DELETE FROM Client WHERE Client = {id}");
        }

        public DataSet UpdateClient(int id)
        {
            return Controller.CarryCommand($"UPDATE Client SET  WHERE = {id}");
        }

    }
}
