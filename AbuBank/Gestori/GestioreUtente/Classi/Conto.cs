using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AbuBank.Gestori.GestioreUtente.Classi
{
    internal class Conto
    {
        public int ID { get; }
        public string Nome { get; }
        public string Codice { get; }
        public string CVC { get; }
        public string Scadenza { get; }
        private string Pin;

        // Parameterless constructor
        public Conto() { }

        // Constructor with parameters
        [JsonConstructor]
        public Conto(int id, string nome, string codice, string cvc, string scadenza, string pin)
        {
            ID = id;
            Nome = nome;
            Codice = codice;
            CVC = cvc;
            Scadenza = scadenza;
            Pin = pin;
        }

        public Conto(string nome, string codice, string cvc, string scadenza, string pin)
        {
            ID = new GestoreID().GetaValidID();
            Nome = nome;
            Codice = codice;
            CVC = cvc;
            Scadenza = scadenza;
            Pin = pin;
        }

        

        public bool isValid()
        {
            if (ID == 0 || Nome == null || Codice == null || CVC == null || Scadenza == null || Pin == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isValidPin(string pin)
        {
            if (pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
