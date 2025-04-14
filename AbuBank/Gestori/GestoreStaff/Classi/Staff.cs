using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbuBank.Gestori.GestoreStaff
{
    internal class Staff
    {
        public string _nome { get; }
        public string _cognome { get; }
        public DateTime _born { get; }
        public string _indirizzo { get; }
        public string _citta { get; }
        public int _CAP { get; }
        public string _telefono { get; }
        public string _email { get; }
        public string type { get; }


        public Staff(string nome, string cognome, DateTime born, string indirizzo, string citta, int CAP, string telefono, string email, string type)
        {
            _nome = nome;
            _cognome = cognome;
            _born = born;
            _indirizzo = indirizzo;
            _citta = citta;
            _CAP = CAP;
            _telefono = telefono;
            _email = email;
            this.type = type;
        }

        public bool isvalid()
        {
            if (type == "Manager" || type == "Admin" || type == "Impiegato")
            {
                return true;
            }
            return false;
        }
    }
}
