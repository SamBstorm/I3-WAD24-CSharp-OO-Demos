using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_Encapsulation
{
    public class Login
    {
        private string _email;

        public string Email
        {
            get {
                return _email.ToLower();
            }
            set {
                //Plus tard remplacer les "return" par des Exceptions
                if (value is null) return; 
                value = value.Trim();
                if (value.Length > 320) return;
                if (value.IndexOf('@') < 1 && value.IndexOf('@') > value.Length-1) return; 
                _email = value;
            }
        }

        private string _password;

        public string Password
        {
            private get 
            {
                return _password;
            }
            set
            {
                if (value is null) return;
                value = value.Trim();
                if (value.Length < 8 || value.Length > 32) return;
                _password = value;
            }
        }

        public bool CheckIdentity(string email, string password)
        {
            return Email == email && Password == password;
        }

    }
}
