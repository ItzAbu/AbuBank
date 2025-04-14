using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AbuBank.Gestori.GestioreUtente
{
    public class GestoreID
    {
        public int GetaValidID()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Dati\BankInfos\Conti\ArchivioConti.json");

            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            var conti = jsonObject["Conti"];
            int maxId = conti.Children<JProperty>().Max(p => int.Parse(p.Name));
            return maxId + 1;
        }
    }
}
