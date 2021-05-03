using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class IndividualClient : Client
    {
        public IndividualClient(string businessID, string clientContract, string clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position, string clientID, string altNum, string altContact, string clientServiceLevel) : base(businessID, clientContract, clientAddress, clientName, clientSurname, clientNumber, callsMade, position, clientID, altNum, altContact, clientServiceLevel)
        {
            this.BusinessID = businessID;
            this.ClientContract = clientContract;
            this.ClientAddress = clientAddress;
            this.ClientName = clientName;
            this.ClientSurname = clientSurname;
            this.ClientNumber = clientNumber;
            this.CallsMade = callsMade;
            this.Position = position;
            this.ClientID = clientID;
            this.AltNum = altNum;
            this.AltContact = altContact;
            this.ClientServiceLevel = clientServiceLevel;
        }
    }
}