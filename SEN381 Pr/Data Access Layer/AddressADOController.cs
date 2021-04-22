using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class AddressADOController
    {

        ADOController Controller = new ADOController();

        public DataSet LoadData()
        {
            return Controller.CarryCommand("SELECT * FROM Address");
        }

        public DataSet InsertData(string Addressid, string street, string code, string city, string country)
        {
            return Controller.CarryCommand($"INSERT INTO Address(AddressId,Street,PostalCode,City,Country) VALUES ({Addressid},{street},'{code}','{country}')");
        }

        public DataSet DeleteService(Address adr)
        {
            return Controller.CarryCommand($"DELETE FROM Address WHERE AddressId = '{adr.AddressId}'");
        }

        public DataSet UpdateService(Address adr)
        {
            return Controller.CarryCommand($"UPDATE AddressId SET Street = '{adr.Street}',PostalCode = '{adr.Code}',City = '{adr.City}',Country = {adr.Country} WHERE AddressId = '{adr.AddressId}'");
        }
    }
}
