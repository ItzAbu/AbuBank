using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbuBank.Gestori.GestioreUtente.CartaDiCredito;
using AbuBank.Gestori.GestioreUtente.Classi;

namespace AbuBank.Gestori.GestioreUtente
{
    internal class GestoreUtente
    {
        private Dictionary<User, Conto> utenteConto = new Dictionary<User, Conto>();


        public GestoreUtente()
        {
            //ciao
            
        }

        public void start()
        {
            

            string path = @"..\..\Dati\Utenti\";
            string[] directories = System.IO.Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                
                string[] files = System.IO.Directory.GetFiles(directory);
                User temp = null;
                Conto temp1 = null;

                if(directory.EndsWith("utente0"))
                {
                    continue;
                }

                string json = System.IO.File.ReadAllText(directory + "\\DatiPersonali.json");
                var jsonObject = Newtonsoft.Json.Linq.JObject.Parse(json);
                temp = jsonObject["Dati_Personali"].ToObject<User>();

                string json2 = System.IO.File.ReadAllText(directory + "\\DatiConto.json");
                var jsonObject2 = Newtonsoft.Json.Linq.JObject.Parse(json2);
                temp1 = jsonObject2["Conto"].ToObject<Conto>();

                if (temp != null && temp1 != null)
                {
                    utenteConto.Add(temp, temp1);

                }
            }

            foreach(var u in utenteConto)
            {
                MessageBox.Show(u.Value.ID + " " + u.Key._nome);
            }
        }

        public Conto CreateUser(User s)
        {
            if (s.isValid())
            {

                bool flag = false;
                string codice = CodiceCreator.GeneraCodiceCartaDiCredito();
                string cvc = CodiceCreator.Cvc();
                string scadenza = CodiceCreator.Scadenza();
                string pin = CodiceCreator.Pin();
                Conto conto = new Conto(s._nome, codice, cvc, scadenza, pin);
                MessageBox.Show("Conto creato con successo! \n" +
                    "ID: " + conto.ID + "\n" +
                    "Nome: " + conto.Nome + "\n" +
                    "Codice: " + conto.Codice + "\n" +
                    "CVC: " + conto.CVC + "\n" +
                    "Scadenza: " + conto.Scadenza + "\n" +
                    "Pin: " + pin + "(NON VERRA RIMOSTRATO!!)");

                if (!SaveFile.SaveNewUser(s, conto, pin))
                {
                    MessageBox.Show("Utente già esistente! \n" +
                        "Conto non creato!");
                    return null; // User already exists
                }

                utenteConto.Add(s, conto);
                return conto;
            }
            else
            {
                MessageBox.Show("Dati non validi! \n" +
                    "Conto non creato!");
                return null;
            }
        }

        public Dictionary<User, Conto> allUsers()
        {
            return utenteConto;
        }

        public int getID(User s)
        {
            foreach (var item in utenteConto)
            {
                if (item.Key == s)
                {
                    return item.Value.ID;
                }
            }
            return 0;
        }
    }
}
