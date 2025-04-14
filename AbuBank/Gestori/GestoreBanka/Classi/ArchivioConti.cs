using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace AbuBank.Gestori.GestoreBanka.Classi
{
    internal class ArchivioConti
    {
        private Dictionary<int, double> archivio = new Dictionary<int, double>();

        public ArchivioConti()
        {
            string path = @"..\..\Dati\BankInfos\Conti\ArchivioConti.json";
            string json = File.ReadAllText(path);
            JObject conti = JObject.Parse(json);

            foreach (var conto in conti["Conti"].Children<JProperty>())
            {
                int id = int.Parse(conto.Name);
                double saldo = (double)conto.Value["Saldo"];
                archivio[id] = saldo;
            }
        }

        public void addTransazione(bool type /*false entrata, true uscita*/, int id, double importo)
        {
            string path = @"..\..\Dati\BankInfos\Conti\Transazioni.json";
            string json = File.ReadAllText(path);
            JObject transazioni = JObject.Parse(json);
            string tipoTransazione = type ? "Uscita" : "Entrata";

            // Verifica se la sezione esiste, altrimenti creala
            if (transazioni[tipoTransazione] == null)
            {
                MessageBox.Show("Creazione della sezione " + tipoTransazione);
                transazioni[tipoTransazione] = new JObject();
            }

            int newId = transazioni[tipoTransazione].Count();

            JObject nuovaTransazione = new JObject
            {
                ["ID"] = id,
                ["Data"] = DateTime.Now.ToString("yyyy-MM-dd"),
                ["Importo"] = importo
            };

            transazioni[tipoTransazione][newId.ToString()] = nuovaTransazione;
            File.WriteAllText(path, transazioni.ToString());
        }

        public List<Tuple<string, int, double, DateTime>> GetAllTransactions()
        {
            string path = @"..\..\Dati\BankInfos\Conti\Transazioni.json";
            string json = File.ReadAllText(path);
            JObject transazioni = JObject.Parse(json);
            List<Tuple<string, int, double, DateTime>> listaTransazioni = new List<Tuple<string, int, double, DateTime>>();

            foreach (var tipo in transazioni)
            {
                foreach (var tr in tipo.Value.Children<JProperty>())
                {
                    string idAzione = (tipo.Key == "Entrata" ? "E" : "U") + tr.Name;
                    int idUtente = (int)tr.Value["ID"];
                    double importo = (double)tr.Value["Importo"];
                    DateTime data = DateTime.ParseExact((string)tr.Value["Data"], "yyyy-MM-dd", null);
                    listaTransazioni.Add(new Tuple<string, int, double, DateTime>(idAzione, idUtente, importo, data));
                }
            }

            return listaTransazioni;
        }

        public bool Deposita(int id, double importo)
        {
            if (archivio.ContainsKey(id))
            {
                archivio[id] += importo;
                SalvaArchivio();
                addTransazione(false, id, importo);
                return true;
            }
            return false;
        }

        public bool Trasferisci(int mittente, int destinatario, double importo)
        {
            if (archivio.ContainsKey(mittente) && archivio.ContainsKey(destinatario))
            {
                if (archivio[mittente] >= importo)
                {
                    archivio[mittente] -= importo;
                    archivio[destinatario] += importo;
                    addTransazione(true, mittente, importo);
                    addTransazione(false, destinatario, importo);
                    SalvaArchivio();
                    return true;
                }
                return false;
            }
            return false;
        }

        public double getSaldo(int id)
        {
            if (archivio.ContainsKey(id))
            {
                return archivio[id];
            }
            return 0;
        }

        public bool Preleva(int id, double importo)
        {
            if (archivio.ContainsKey(id))
            {
                if (archivio[id] >= importo)
                {
                    archivio[id] -= importo;
                    SalvaArchivio();
                    addTransazione(true, id, importo);
                    return true;
                }
                return false;
            }
            return false;
        }

        public void SalvaArchivio()
        {
            string path = @"..\..\Dati\BankInfos\Conti\ArchivioConti.json";
            JObject conti = new JObject();
            conti["Conti"] = new JObject();
            foreach (var conto in archivio)
            {
                conti["Conti"][conto.Key.ToString()] = new JObject
                {
                    ["Saldo"] = conto.Value
                };
            }
            File.WriteAllText(path, conti.ToString());
        }
    }
}
