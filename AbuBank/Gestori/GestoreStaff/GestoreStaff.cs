using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbuBank.Gestori.GestoreStaff.Classi;
using Newtonsoft.Json.Bson;

namespace AbuBank.Gestori.GestoreStaff
{
    internal class GestoreStaff
    {

        Dictionary<Staff, LoginStaff> _staff = new Dictionary<Staff, LoginStaff>();

        public GestoreStaff()
        {
            

        }

        public void start()
        {
            string path = @"..\..\Dati\Staff\";
            string[] directories = System.IO.Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                string[] files = System.IO.Directory.GetFiles(directory);
                Staff temp = null;
                LoginStaff temp1 = null;

                if (directory.EndsWith("staff0"))
                {
                    continue;
                }

                string json = System.IO.File.ReadAllText(directory + "\\DatiPersonali.json");
                var jsonObject = Newtonsoft.Json.Linq.JObject.Parse(json);
                temp = jsonObject["Dati_Personali"].ToObject<Staff>();

                string json2 = System.IO.File.ReadAllText(directory + "\\DatiStaff.json");
                var jsonObject2 = Newtonsoft.Json.Linq.JObject.Parse(json2);
                temp1 = jsonObject2["Staff"].ToObject<LoginStaff>();

                if (temp != null && temp1 != null)
                {
                    _staff.Add(temp, temp1);
                }
            }
        }

        public string CreateStaff(Staff s)
        {
            string password = PasswordGenerator.GeneratePassword();
            if (s.isvalid())
            {
                string nome = s._nome.Replace(" ", "");
                string path = @"..\..\Dati\Staff\" + nome + "_" + s._cognome;
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                else
                {
                    // Check if the user already exists
                    string[] files = System.IO.Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        if (file.EndsWith("DatiPersonali.json"))
                        {
                            return null; // User already exists
                        }
                    }
                }
                // Create user details JSON file
                string userDetailsFilePath = System.IO.Path.Combine(path, "DatiPersonali.json");
                var userDetails = new
                {
                    Dati_Personali = new
                    {
                        Nome = s._nome,
                        Cognome = s._cognome,
                        Data_di_Nascita = s._born.ToString("dd/MM/yyyy"),
                        Indirizzo = s._indirizzo,
                        Città = s._citta,
                        CAP = s._CAP.ToString(),
                        Telefono = s._telefono,
                        Email = s._email
                    }
                };
                System.IO.File.WriteAllText(userDetailsFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(userDetails, Newtonsoft.Json.Formatting.Indented));
                // Create user accounts JSON file
                string userContiFilePath = System.IO.Path.Combine(path, "DatiStaff.json");
                var userConti = new
                {
                    Staff = new
                    {
                        type = s.type,
                        name = s._nome + "." + s._cognome,
                        password = password
                    }
                };
                System.IO.File.WriteAllText(userContiFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(userConti, Newtonsoft.Json.Formatting.Indented));

                //Aggiungo all mappa
                _staff.Add(s, new LoginStaff(s.type, s._nome + "." + s._cognome, password));
            }
            return password;
        }


        public Dictionary<Staff, LoginStaff> allStaff()
        {
            return _staff;
        }



    }
}
