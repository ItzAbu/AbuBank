using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbuBank.Gestori.GestoreStaff.Classi
{
    internal class LoginStaff
    {

        public string type {  get; }
        public string name { get; }
        private string password { get; }

        public LoginStaff(string type, string name, string password)
        {
            this.type = type;
            this.name = name;
            this.password = password;
        }

        public bool isValid()
        {
            if (type == "Manager" || type == "Admin" || type == "Impiegato")
            {
                return true;
            }
            return false;
        }

        public bool isPasswordValid(string password)
        {
            if (this.password == password)
            {
                return true;
            }
            return false;
        }

    }
}
