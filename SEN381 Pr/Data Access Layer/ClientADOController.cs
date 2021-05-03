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
            return Controller.CarryCommand("SELECT * FROM Clients");
        }

        public DataSet InsertClient(IndividualClient client)
        {
            return Controller.CarryCommand($"INSERT INTO Clients (ClientId,ClientName,BusinessId,ContractId,Surname,Number,AddressId,AlternativeContact,AlternativeNumber,CallsMade,Position,ClientServiceLevel) VALUES ('{client.ClientID}','{client.ClientName}','{client.BusinessID}','{client.ClientContract}','{client.ClientSurname}','{client.ClientNumber}',{int.Parse(client.ClientAddress)},'{client.AltContact}','{client.AltNum}',{int.Parse(client.CallsMade)},'{client.Position}','{client.ClientServiceLevel}')");
        }

        public DataSet DeleteClient(IndividualClient client)
        {
            return Controller.CarryCommand($"DELETE FROM Clients WHERE ClientId = '{client.ClientID}'");
        }

        public DataSet UpdateClient(IndividualClient client)
        {
            return Controller.CarryCommand($"UPDATE Clients SET ClientName = '{client.ClientName}',BusinessId = '{client.BusinessID}', ContractId = '{client.ClientContract}',Surname= '{client.ClientSurname}',Number = '{client.ClientNumber}',AddressId = {int.Parse(client.ClientAddress)},AlternativeContact = '{client.AltContact}',AlternativeNumber = '{client.AltNum}',CallsMade = {int.Parse(client.CallsMade)},Position = '{client.Position}',ClientServiceLevel = '{client.ClientServiceLevel}'  WHERE ClientId = '{client.ClientID}'");
        }

        public int CountClients()
        {
            return Controller.CarryCommand("SELECT * FROM Clients").Tables[0].Rows.Count;
        }

        public List<string> ClientData(string id)
        {
            List<string> temp = new List<string>();

            DataSet set = Controller.CarryCommand($"SELECT ContractId,AddressId FROM Clients WHERE ClientId = '{id}'");

            temp.Add(set.Tables[0].Rows[0]["ContractId"].ToString());
            temp.Add(set.Tables[0].Rows[0]["AddressId"].ToString());

            return temp;
        }

    }
}
