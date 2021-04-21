using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Address 
    public class Address
    {
        private string _addressId;
        private string _street;
        private string _code;
        private string _city;
        private string _country;

        #region Constructor
        public Address( string id,string street, string code, string city, string country)
        {
            _addressId = id;
            _street = street;
            _code = code;
            _city = city;
            _country = country;
        }

        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Street { get => _street; set => _street = value; }
        public string Code { get => _code; set => _code = value; }
        public string City { get => _city; set => _city = value; }
        public string Country { get => _country; set => _country = value; }
        #endregion
        
        public Client Client
        {
            get => default;
            set
            {
            }
        }
        #region Methods

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   _addressId == address._addressId &&
                   _street == address._street &&
                   _code == address._code &&
                   _city == address._city &&
                   _country == address._country &&
                   AddressId == address.AddressId &&
                   Street == address.Street &&
                   Code == address.Code &&
                   City == address.City &&
                   Country == address.Country;
        }
        #endregion

        #region GetHashCode
        public override int GetHashCode()
        {
            int hashCode = 260441318;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_addressId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            return hashCode;
        }
        #endregion
        #region ToString
        public override string ToString()
        {
            return $"ID:{AddressId},Street:{Street},Code:{Code},City:{City}, Country:{Country}"; ;
        }
        #endregion
        #endregion
    }
    #endregion
}