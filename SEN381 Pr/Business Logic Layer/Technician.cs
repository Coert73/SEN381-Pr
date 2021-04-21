using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Technician
    public class Technician
    {
        #region Constructor
        private string _name;
        private string _surname;
        private string _number;

        public Technician(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Number { get => _number; set => _number = value; }
        #endregion

        #region Methods
        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Technician technician &&
                   _name == technician._name &&
                   _surname == technician._surname &&
                   _number == technician._number;
        }
        #endregion
        #region GetHashCode
        public override int GetHashCode()
        {
            int hashCode = -1019785001;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_number);
            return hashCode;
        }
        #endregion
        #endregion
    }
    #endregion
}