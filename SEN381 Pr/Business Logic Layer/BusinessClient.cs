using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region BusinessClient
    public class BusinessClient
    {
        #region Constructor

        private string _businessName;
        private string _businessID;

        public BusinessClient(string businessName, string businessID)
        {
            BusinessName = businessName;
            BusinessID = businessID;
        }

        public string BusinessName { get => _businessName; set => _businessName = value; }
        public string BusinessID { get => _businessID; set => _businessID = value; }   

        #endregion

        #region Methods
        #region ToString
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            return obj is BusinessClient client &&
                   _businessName == client._businessName &&
                   _businessID == client._businessID &&
                   BusinessName == client.BusinessName &&
                   BusinessID == client.BusinessID;
        }

        #endregion
        #region GetHasCode
        public override int GetHashCode()
        {
            int hashCode = 675541270;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_businessName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_businessID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BusinessName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BusinessID);
            return hashCode;
        }
        #endregion

        #endregion
    }
    #endregion
}