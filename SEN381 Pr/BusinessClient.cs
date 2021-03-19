using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class BusinessClient : Client
    {
        public override string BusinessID { get => BusinessID; set => BusinessID = value; }
        public override Contract ClientContract { get => ClientContract; set => ClientContract = value; }
        public override Address ClientAddress { get => ClientAddress; set => ClientAddress = value; }
        public override string ClientName { get => ClientName; set => ClientName = value; }
        public override string ClientSurname { get => ClientSurname; set => ClientSurname = value; }
        public override string ClientNumber { get => ClientNumber; set => ClientNumber = value; }
        public override string CallsMade { get => CallsMade; set => CallsMade = value; }
        public override string Position { get => Position; set => Position = value; }

        public BusinessClient(string businessID, Contract clientContract, Address clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position)
        {
            BusinessID = businessID;
            ClientContract = clientContract;
            ClientAddress = clientAddress;
            ClientName = clientName;
            ClientSurname = clientSurname;
            ClientNumber = clientNumber;
            CallsMade = callsMade;
            Position = position;
        }

        public override bool Equals(object obj)
        {
            return obj is BusinessClient client &&
                   BusinessID == client.BusinessID &&
                   EqualityComparer<Contract>.Default.Equals(ClientContract, client.ClientContract) &&
                   EqualityComparer<Address>.Default.Equals(ClientAddress, client.ClientAddress) &&
                   ClientName == client.ClientName &&
                   ClientSurname == client.ClientSurname &&
                   ClientNumber == client.ClientNumber &&
                   CallsMade == client.CallsMade &&
                   Position == client.Position &&
                   EqualityComparer<BusinessClient>.Default.Equals(BusinessClient, client.BusinessClient) &&
                   EqualityComparer<IndividualClient>.Default.Equals(IndividualClient, client.IndividualClient) &&
                   BusinessID == client.BusinessID &&
                   EqualityComparer<Contract>.Default.Equals(ClientContract, client.ClientContract) &&
                   EqualityComparer<Address>.Default.Equals(ClientAddress, client.ClientAddress) &&
                   ClientName == client.ClientName &&
                   ClientSurname == client.ClientSurname &&
                   ClientNumber == client.ClientNumber &&
                   CallsMade == client.CallsMade &&
                   Position == client.Position;
        }

        public override int GetHashCode()
        {
            int hashCode = 920791913;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BusinessID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Contract>.Default.GetHashCode(ClientContract);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(ClientAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CallsMade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Position);
            hashCode = hashCode * -1521134295 + EqualityComparer<BusinessClient>.Default.GetHashCode(BusinessClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<IndividualClient>.Default.GetHashCode(IndividualClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BusinessID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Contract>.Default.GetHashCode(ClientContract);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(ClientAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CallsMade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Position);
            return hashCode;
        }
    }
}