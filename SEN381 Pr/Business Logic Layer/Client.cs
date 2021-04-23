using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Client
    public abstract class Client
    {

        private string _businessID;
        private string _clientcontract;
        private string _clientaddress;
        private string _clientname;
        private string _clientsurname;
        private string _number;
        private int _callsMade;
        private string _position;
        private string _clientID;
        private string _altNum;
        private string _altContact;
        private string _Clientservicelevel;


        public abstract string BusinessID { get; set; }
        public abstract string ClientContract { get; set; }
        public abstract string ClientAddress { get; set; }
        public abstract string ClientName { get; set; }
        public abstract string ClientSurname { get; set; }
        public abstract string ClientNumber { get; set; }
        public abstract string CallsMade { get; set; }
        public abstract string Position { get; set; }
        public abstract string ClientID { get; set; }
        public abstract string AltNum { get; set; }
        public abstract string AltContact { get; set; }
        public abstract string ClientServiceLevel { get; set; }
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