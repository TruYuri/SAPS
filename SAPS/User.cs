using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;
        private UserType _permissions;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
        }

        public UserType Permissions
        {
            get
            {
                return _permissions;
            }
        }

        public User(string n, string e, string p, UserType ut)
        {
            _name = n;
            _email = e;
            _password = p;
            _permissions = ut;
        }
    }
}
