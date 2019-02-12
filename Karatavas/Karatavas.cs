using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    public class Karatavas
    {
        private string minamaisVards;
        private string[] atminetaisVards;

        private string[] vardnica =
            {
            "KROKODILS",
            "OLA",
            "BIEZPIENMAIZE"
        };

        public Karatavas()
        {

        }

        public void SaktSpeli()
        {
            // 1. Aizpilda minamaisVardsare izveleto vardu
            // Console.Write("Ievadi minamo vardu: ");
            Random rnd = new Random();
            int pozicija = rnd.Next(vardnica.Length);

            minamaisVards = vardnica[pozicija];

            //2. atminetaisVards aizpilda are "*" tik, cik varda burti

            atminetaisVards = new string[minamaisVards.Length];



            for (int i=0 ;i < minamaisVards.Length ;i++ )
            {
                atminetaisVards[i] = "*";
            }


            //string[] atminetaisVardsNew = atminetaisVards.Select(vards => vards.Replace(minamaisBurts, atminetaisBurts)).ToArray();


        }

        public bool IrAtminets()
        {
            // 1. nosaka vai vards ir atminets
            // atgriez tur/ false

            foreach (string burts in atminetaisVards)
            {
                if (burts == "*")
                {
                    return false;
                }
            }

            return true;

        }



        //public bool Turpinat(string atbilde)
        //{
        //    if (atbilde == "n")
        //    {
        //        return false;
        //    }
        //    else if (atbilde == "y")
        //    {
        //        return true;
        //    }

        //}




        public bool Minet(string burts)
        {
            burts = burts.ToUpper();
            //1. atgriez false, ja burts nav varda

            if (string.IsNullOrEmpty(burts))
            {
                return false;
            }

            if (!minamaisVards.Contains(burts))
            {
                return false;
            }


            //2. atgriz true, ja burts ir varda
            // Azivieto minamaisVards ar '*' ar burtu konkretaja pozicija

            int pozicija = minamaisVards.IndexOf(burts);
            while (pozicija != -1)
            {
                atminetaisVards[pozicija] = burts;
                pozicija = minamaisVards.IndexOf(burts, 1 + pozicija);
            }

            return true;

        }

        public string Vards()
        {
            //1. atgriez minamaisVards ka tekstu  (tring)

            // 1. variants
            //string teksts = "";
            //foreach (string burts in atminetaisVards)
            //{
            //    teksts += burts;
            //}
            //return teksts;

            //2.variants
            return String.Join(" ", atminetaisVards);

        }

    }
}
