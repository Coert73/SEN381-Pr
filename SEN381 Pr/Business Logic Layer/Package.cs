using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEN381_Pr
{
    #region Package
    public class Package
    {
        #region Constructor
        private string _id;
        private string _name;
        private string _type;
        private List<string> _services;

        public Package(string id, string name, string type, List<string> services)
        {
            _id = id;
            _name = name;
            _type = type;
            _services = services;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public List<string> Services { get => _services; set => _services = value; }
        #endregion

        #region Methods
        #region Equals
        public override bool Equals(object obj)
        {
            return obj is Package package &&
                   _id == package._id &&
                   _name == package._name &&
                   _type == package._type &&
                   EqualityComparer<List<string>>.Default.Equals(_services, package._services) &&
                   Id == package.Id &&
                   Name == package.Name &&
                   Type == package.Type &&
                   EqualityComparer<List<string>>.Default.Equals(Services, package.Services);
        }
        #endregion
        #region GetHashCode
        public override int GetHashCode()
        {
            int hashCode = -735467416;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_type);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(_services);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(Services);
            return hashCode;
        }
        #endregion
        #region ToString
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
        #endregion
    }
    #endregion
}