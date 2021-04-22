using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region
    public class IndividualClient : Client
    {
        #region Constructor
        public override string BusinessID { get => BusinessID; set => BusinessID = value; }
        public override Contract ClientContract { get => ClientContract; set => ClientContract = value; }
        public override Address ClientAddress { get => ClientAddress; set => ClientAddress = value; }
        public override string ClientName { get => ClientName; set => ClientName = value; }
        public override string ClientSurname { get => ClientSurname; set => ClientSurname = value; }
        public override string ClientNumber { get => ClientNumber; set => ClientNumber = value; }
        public override string CallsMade { get => CallsMade; set => CallsMade = value; }
        public override string Position { get => Position; set => Position = value; }
        public override string AltContact { get => AltContact; set => AltContact = value; }
        public override string AltNum { get => AltNum ; set => AltNum = value; }
        public override string ClientID { get => ClientID ; set => ClientID = value; }
        public IndividualClient(string businessID, Contract clientContract, Address clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position,string altcontact,string altnum,string clientID)
        {
            BusinessID = businessID;
            ClientContract = clientContract;
            ClientAddress = clientAddress;
            ClientName = clientName;
            ClientSurname = clientSurname;
            ClientNumber = clientNumber;
            CallsMade = callsMade;
            Position = position;
            AltContact = altcontact;
            AltNum = altnum;
            ClientID = clientID;

        }
        #endregion
        #region Methods
        #region ToString
        public override string ToString()
        {
            return $"Name:{ClientName},BusinessID:{BusinessID},Surname:{ClientSurname}, Number:{ClientNumber}, CallsNo.:{CallsMade},Position:{Position},Alternative Contact:{AltContact}, Alternative Number:{AltNum}, ClientID:{ClientID}"; 
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is IndividualClient client &&
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
                   Position == client.Position &&
                   AltContact == client.AltContact &&
                   AltNum == client.AltNum &&
                   ClientID == client.ClientID;
        }
        #endregion

        #region GetHashCode
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
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AltContact);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AltNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientID);

            return hashCode;
        }
        #endregion
#endregion
    }
#endregion
}