using System;

namespace MD2
{
    class Program
    {
        static void Main(string[] args)
        {          
            bool result = IsEven();

            switch (result)
            {
                case true:
                    Console.WriteLine($"The number is even.");
                    break;
                case false:
                    Console.WriteLine($"The number is NOT even.");
                    break;
                default:
                    break;
            }
        }

        //1) Uztaisīt metodi ar parametriem (2 int tipa skaitļi). Ar return tiek padots lielākais skaitlis.
        public static int ReturnInt(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a < b)
            {
                return b;
            }
            else
            {
                Console.Write("The numbewrs are the same");
                return a;
            }
        }

        //2) Pašiem patstāvīgi pameklēt, kas ir div un mod. (/ un % ) Uztaisīt metodi, kas atgriež ar return to, vai skaitlis ir pāra vai nav (return tips- boolean) 
        public static bool IsEven()
        {

            Console.Write("Please enter a number to check if it is even: ");
            int input;

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: please make sure you enter an integer!");
                throw;
            }

            int result = input % 2;

            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
