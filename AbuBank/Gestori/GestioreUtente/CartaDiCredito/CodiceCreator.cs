using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbuBank.Gestori.GestioreUtente.CartaDiCredito
{
    internal class CodiceCreator
    {
        private static Random random = new Random();

        public CodiceCreator() { }

        public static string GeneraCodiceCartaDiCredito()
        {
            StringBuilder codice = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                codice.Append(GeneraBlocco());
                if (i < 3)
                {
                    codice.Append(" ");
                }
            }
            return codice.ToString();
        }

        private static string GeneraBlocco()
        {
            StringBuilder blocco = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                blocco.Append(random.Next(0, 10));
            }
            return blocco.ToString();
        }


        public static string Cvc()
        {
            StringBuilder cvc = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                cvc.Append(random.Next(0, 10));
            }
            return cvc.ToString();
        }

        public static string Scadenza()
        {
            DateTime scadenza = DateTime.Now.AddYears(4);
            return scadenza.ToString("MM/yy");
        }

        public static string Pin()
        {
            StringBuilder pin = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                pin.Append(random.Next(0, 10));
            }
            return pin.ToString();
        }
    }
}
