using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Paroles validācija - Izveidot aplikāciju, kura validēs paroli:
            ///1) Paroles garumu, min garums ir 8 simboli
            ///2) Pārbaudīs, vai ievadītās paroles sakrīt
            ///3) Pārbaudīs, vai parolē ir gan skaitļi, gan burti(char.IsDigit &char.IsLetter)
            ///*Lietotājam prasīs divas reizes ievadīt paroli, kā jau reālā vidē.
            ///Ja validācijas ir veiksmīgas, izvadīt paroli.Ja kāda validācija ir neveiksmīga, izvadīt attiecīgu kļūdas paziņojumu.
            ///



            //Console.WriteLine("Ievadi paroli: ");
            //string passwordOne = Console.ReadLine();

            //Console.WriteLine("Ievadi paroli atkartoti: ");
            //string passwordTwo = Console.ReadLine();

            //if (passwordOne.Length < 8 || passwordTwo.Length < 8)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}


        }

        public bool CheckPasswords(string password1, string password2)
        {
            if (password1.Length < 8 || password2.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckPasswordLenght(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
