using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Pr
{
    class User
    {
        private string _username;

        public User(string username)
        {
            Username = username;
        }

        public string Username { get => _username; set => _username = value; }
    }
}
