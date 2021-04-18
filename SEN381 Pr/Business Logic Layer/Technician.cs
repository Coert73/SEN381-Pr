using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    public class Technician
    {
        private string _name;
        private string _surname;
        private string _position;

        public Technician(string name, string surname, string position)
        {
            _name = name;
            _surname = surname;
            _position = position;
        }

        public Jobs Jobs
        {
            get => default;
            set
            {
            }
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Position { get => _position; set => _position = value; }

        public override bool Equals(object obj)
        {
            return obj is Technician technician &&
                   _name == technician._name &&
                   _surname == technician._surname &&
                   _position == technician._position &&
                   EqualityComparer<Jobs>.Default.Equals(Jobs, technician.Jobs) &&
                   Name == technician.Name &&
                   Surname == technician.Surname &&
                   Position == technician.Position;
        }

        public override int GetHashCode()
        {
            int hashCode = -2134339200;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_position);
            hashCode = hashCode * -1521134295 + EqualityComparer<Jobs>.Default.GetHashCode(Jobs);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Position);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Name:{Name},Surname:{Surname},Position:{Position}"; ;
        }
    }
}