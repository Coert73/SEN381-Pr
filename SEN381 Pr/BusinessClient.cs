using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class BusinessClient
    {
        private string _name;
        private string _surname;
        private bool _type;
        private string _address;
        private string _contract;
        private Service _clientService;
        private int _callsMade;
        private string _referenceNumber;
        private List<IndividualClient> _members;
        private IndividualClient _mainContactMember;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public bool Type { get => _type; set => _type = value; }
        public string Address { get => _address; set => _address = value; }
        public string Contract { get => _contract; set => _contract = value; }
        public Service ClientService { get => _clientService; set => _clientService = value; }
        public int CallsMade { get => _callsMade; set => _callsMade = value; }
        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        public List<IndividualClient> Members { get => _members; set => _members = value; }
        public IndividualClient MainContactMember { get => _mainContactMember; set => _mainContactMember = value; }

        public Call Call
        {
            get => default;
            set
            {
            }
        }
    }
}