using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbuBank.Gestori.GestioreUtente;
using AbuBank.Gestori.GestioreUtente.Classi;
using AbuBank.Gestori.GestoreBanka.Classi;

namespace AbuBank.Gestori.GestoreBanka
{
    internal class GestoreBanka
    {
        Dictionary<User, Conto> Conti = new Dictionary<User, Conto>();
        ArchivioConti con = new ArchivioConti();
        

        public GestoreBanka()
        {
            Conti = new GestoreUtente().allUsers();
        }

        public void reload()
        {
            Conti = new GestoreUtente().allUsers();
        }

        public bool Deposita(int id, double importo)
        {
            return con.Deposita(id, importo);
        }

        public bool Trasferisci(int mitten, int dest, double importo)
        {
            return con.Trasferisci(mitten, dest, importo);
        }

        public bool Preleva(int id, double importo)
        {
            return con.Preleva(id, importo);
        }

        public double getSaldo(int id)
        {
            return con.getSaldo(id);
        }


    }
}
