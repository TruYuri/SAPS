using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class User
    {
        private static User _instance;

        private string _name;
        private string _email;
        private UserType _permissions;

        public static User Instance
        {
            get
            {
                return _instance;
            }
        }

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

        public UserType Permissions
        {
            get
            {
                return _permissions;
            }
        }

        public User(string n, string e, UserType ut)
        {
            _instance = this;

            _name = n;
            _email = e;
            _permissions = ut;
        }

        public void Destroy()
        {
            _instance = null;
        }
    }
}
