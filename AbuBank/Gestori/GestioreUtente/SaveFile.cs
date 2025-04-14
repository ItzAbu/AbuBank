using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbuBank.Gestori.GestioreUtente.Classi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AbuBank.Gestori.GestioreUtente
{
    internal class SaveFile
    {
        public static bool SaveNewUser(User s, Conto c, string pin)
        {
            try
            {
                string nome = s._nome.Replace(" ", "");
                string directoryPath = @"..\..\Dati\Utenti\" + nome + "_" + s._cognome;
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                else
                {
                    // Check if the user already exists
                    string[] files = Directory.GetFiles(directoryPath);
                    foreach (string file in files)
                    {
                        if (file.EndsWith("DatiPersonali.json"))
                        {
                            return false; // User already exists
                        }
                    }
                }

                    // Create user details JSON file
                    string userDetailsFilePath = Path.Combine(directoryPath, "DatiPersonali.json");
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
                File.WriteAllText(userDetailsFilePath, JsonConvert.SerializeObject(userDetails, Formatting.Indented));

                // Create user accounts JSON file
                string userContiFilePath = Path.Combine(directoryPath, "DatiConto.json");
                var userConti = new
                {
                    Conto = new
                    {
                        ID = c.ID,
                        Nome = c.Nome,
                        Codice = c.Codice,
                        CVC = c.CVC,
                        Scadenza = c.Scadenza,
                        Pin = pin
                    }
                };
                File.WriteAllText(userContiFilePath, JsonConvert.SerializeObject(userConti, Formatting.Indented));

                
                // Save Conto 
                string path = @"..\..\Dati\BankInfos\Conti\";
                string ArchivioPath = Path.Combine(path, "ArchivioConti.json");

                JObject archivioConti;
                if (File.Exists(ArchivioPath))
                {
                    archivioConti = JObject.Parse(File.ReadAllText(ArchivioPath));
                }
                else
                {
                    archivioConti = new JObject(new JProperty("Conti", new JObject()));
                }

                var nuovoConto = new JObject
                {
                    ["Saldo"] = 0.0
                };

                archivioConti["Conti"][c.ID.ToString()] = nuovoConto;

                File.WriteAllText(ArchivioPath, archivioConti.ToString(Formatting.Indented));
                

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
