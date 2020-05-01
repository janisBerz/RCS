using System;

namespace Day2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izvelies kuru metodi gribi palaist: 1 - Greetings; 2- ThreeStrings; 3 -BiggestNumber; 4 - SwitchValues. ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Greetings();
            }
            else if (answer == 2)
            {
                ThreeStrings();
            }
            else if (answer == 3)
            {
                BiggestNumber();
            }
            else if (answer == 4)
            {
                SwitchValues();
            }
            else
            {
                Console.WriteLine("Nepareizi ievadita izvele");
            }

            // Ar switch

            switch (answer)
            {
                case 1:
                    Greetings();
                    break;
                case 2:
                    ThreeStrings();
                    break;
                case 3:
                    BiggestNumber();
                    break;
                case 4:
                    SwitchValues();
                    break;
                default:
                    Console.WriteLine("Nepareizi ievadita izvele");
                    break;
            }

            //Greetings();
            //ThreeStrings();
            //BiggestNumber();
            //SwitchValues();
        }

        static void SampleOutput()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
        }

        static void Greetings()
        {
            Console.WriteLine("Ievadiet savu vardu!");
            String name = Console.ReadLine();

            Console.WriteLine("Sveiki, " + name);
        }

        static void ThreeStrings()
        {
            String s1 = InputString();
            String s2 = InputString();
            String s3 = InputString();

            Console.WriteLine(s1 + s2 + s3);
        }

        static String InputString()
        {
            Console.WriteLine("Ievadiet simbolu virkni!");
            String s = Console.ReadLine();

            return s;
        }

        static void BiggestNumber()
        {
            int sk1 = InputNumber();
            int sk2 = InputNumber();
            int sk3 = InputNumber();

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine(sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine(sk2);
            }
            else if (sk3 > sk1 && sk3 > sk2)
            {
                Console.WriteLine(sk3);
            }
        }

        static int InputNumber()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String input = Console.ReadLine();

            int sk = Convert.ToInt32(input);

            return sk;
        }

        static void SwitchValues()
        {
            int a = 3;
            int b = 9;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

            // a = 9, b = 3
            a = a + b;
            //a = 12, b = 3
            b = a - b;
            //a = 12, b = 9
            a = a - b;
            //a = 3, b = 9

            Console.WriteLine(a);
            Console.WriteLine(b);
        }


    }
}