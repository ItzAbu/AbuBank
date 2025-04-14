using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbuBank.Gestori.GestioreUtente
{
    internal class User
    {
        public string _nome { get; }
        public string _cognome { get; }
        public DateTime _born { get; }
        public string _indirizzo { get; }
        public string _citta { get; }
        public int _CAP { get; }
        public string _telefono { get; }
        public string _email { get; }

        public User(string nome, string cognome, DateTime born, string indirizzo, string citta, int CAP, string telefono, string email)
        {
            nome.Replace(" ", "");
            cognome.Replace(" ", "");

            this._nome = nome;
            this._cognome = cognome;
            this._born = born;
            this._indirizzo = indirizzo;
            this._citta = citta;
            this._CAP = CAP;
            this._telefono = telefono;
            this._email = email;
        }

        public bool isValid()
        {
            if (_nome == null || _cognome == null || _indirizzo == null || _citta == null || _CAP == 0 || _telefono == null || _email == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        






        }
}
