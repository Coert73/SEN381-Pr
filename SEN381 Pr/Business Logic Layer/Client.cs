using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Client
    public abstract class Client
    {
        public Client(string businessID, string clientContract, string clientAddress, string clientName, string clientSurname, string clientNumber, string callsMade, string position, string clientID, string altNum, string altContact, string clientServiceLevel)
        {
            BusinessID = businessID;
            ClientContract = clientContract;
            ClientAddress = clientAddress;
            ClientName = clientName;
            ClientSurname = clientSurname;
            ClientNumber = clientNumber;
            CallsMade = callsMade;
            Position = position;
            ClientID = clientID;
            AltNum = altNum;
            AltContact = altContact;
            ClientServiceLevel = clientServiceLevel;
        }

        public string BusinessID { get; set; }
        public string ClientContract { get; set; }
        public string ClientAddress { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientNumber { get; set; }
        public string CallsMade { get; set; }
        public string Position { get; set; }
        public string ClientID { get; set; }
        public string AltNum { get; set; }
        public string AltContact { get; set; }
        public string ClientServiceLevel { get; set; }
        public BusinessClient BusinessClient
        {
            get => default;
            set
            {
            }
        }

        public IndividualClient IndividualClient
        {
            get => default;
            set
            {
            }
        }
    }
    #endregion
}