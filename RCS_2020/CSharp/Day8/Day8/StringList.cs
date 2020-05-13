using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class StringList
    {
        private  List<String> listOfValues;

        public StringList()
        {
            listOfValues = new List<String>();
            listOfValues.Add("aabb");
            listOfValues.Add("aa");
            listOfValues.Add("bb");
        }

        public void Task1()
        {
            //Mes izvadam menu
            //un dodam cilvekam iespeju izveleties
            //1. Izvadit
            //2. Pievienot
            //3. Dzest
            //0. Iziet
            string choiche = "";

            while (choiche != "0")
            {
                Console.WriteLine("1 - Izvadit");
                Console.WriteLine("2 - Pievienot");
                Console.WriteLine("3 - Dzest");
                Console.WriteLine("4 - Meklet");
                Console.WriteLine("0 - Iziet");

                choiche = Console.ReadLine();

                switch (choiche)
                {
                    case "1":
                        Print();
                        break;
                    case "2":
                        Add();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Search();
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private void Search()
        {
            Console.WriteLine("-----------------");
            Console.Write("Meklesanas fraze: ");

            string searchPhrase = Console.ReadLine();
            List<int> resultIndexList = new List<int>();

           
            for (int i = 0; i < listOfValues.Count; i++)
            {
                if (listOfValues[i].Contains(searchPhrase))
                {
                    resultIndexList.Add(i);
                }
            }

            if (resultIndexList.Count > 0)
            {
                for (int i = 0; i < resultIndexList.Count; i++)
                {
                    if (listOfValues[i].Contains(searchPhrase))
                    {
                        Console.WriteLine($"Elemenst {resultIndexList[i]} ar vertibu {listOfValues[resultIndexList[i]]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nekas netika atrasts :(");
            }

            Console.WriteLine("-----------------");
        }

        private void Print()
        {
            Console.WriteLine("-----------------");
            foreach (var value in listOfValues)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("-----------------");
        }

        private void Add()
        {
            Console.WriteLine("-----------------");
            Console.Write("Ievadi vertibu: ");
            listOfValues.Add(Console.ReadLine());
            Console.WriteLine("-----------------");
        }

        private void Delete()
        {
            Console.WriteLine("-----------------");
            Console.Write("Ievadi vertibu kuru velies izdzest: ");
            listOfValues.Remove(Console.ReadLine());
            Console.WriteLine("-----------------");
        }
    }
}
