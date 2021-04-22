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
            return Controller.CarryCommand($"INSERT INTO Clients (BusinessId,ContractId,Name,Surname,Number,CallsMade,Position,AlternativeContact,AlternativeNumber,ClientId) VALUES ({client.BusinessID},{client.ClientContract},'{client.ClientName}','{client.ClientSurname}','{client.ClientNumber}','{client.CallsMade}','{client.Position}','{client.AltContact}','{client.AltNum}','{client.ClientID}')");
        }

        public DataSet DeleteClient(IndividualClient client)
        {
            return Controller.CarryCommand($"DELETE FROM Clients WHERE Client = '{client.ClientID}'");
        }

        public DataSet UpdateClient(IndividualClient client)
        {
            return Controller.CarryCommand($"UPDATE Clients SET BusinessId='{client.BusinessID}',ContractId='{client.ClientContract}',Name='{client.ClientName}',Surname='{client.ClientSurname}',Number='{client.ClientNumber}',CallsMade='{client.CallsMade}',Position='{client.Position}',AlternativeContact='{client.AltContact}',AlternativeNumber='{client.AltNum}'  WHERE ClientId = '{client.ClientID}'");
        }

    }
}
