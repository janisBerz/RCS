using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitluSumma();
            Console.ReadLine();
        }

        static void skaitluSumma()
        {

            Console.Write("Ievadi pirmo skaitli: ");
            float skaitlisViens = int.Parse(Console.ReadLine());

            Console.Write("Ievadi otro skaitli: ");
            float skaitlisDivi = int.Parse(Console.ReadLine());

            // summa
            //int skaitlisSumma = skaitlisViens + skaitlisDivi;
            Console.WriteLine("Skaitļu summa: " + (skaitlisViens + skaitlisDivi));

            // starpība
            //int skaitlisStarpiba = skaitlisViens - skaitlisDivi;
            Console.WriteLine("Skaitļu starpība: " + (skaitlisViens - skaitlisDivi));

            // reizinājums
            //int skaitlisReizinajums = skaitlisViens * skaitlisDivi;
            Console.WriteLine("Skaitļu reizinajums: " + (skaitlisViens * skaitlisDivi));

            // dalījums

            //float skaitlisDalijums = skaitlisViens / skaitlisDivi;
            Console.WriteLine("Skaitļu dalījums: " + skaitlisViens / skaitlisDivi);







        }
    }
}
