using System;
using System.Collections.Generic;

namespace PasswordValidationLibrary
{
    public class PasswordValidator
    {
        static List<string> errors = new List<string>();

        /// <summary>
        /// Validates 2 passwords with multiple validation methods
        /// </summary>
        /// <param name="password1">Password 1</param>
        /// <param name="password2">Password 2</param>
        /// <returns>string List of errors</returns>
        public static List<string> ValidatePassword(string password1, string password2)
        {
            ValidateLength(password1, password2);
            ValidateEqual(password1, password2);
            ValidateDigitsLetters(password1, password2);

            return errors;
        }

        private static void ValidateDigitsLetters(string password1, string password2)
        {
            int letterCount = 0, numberCount = 0;
            foreach (char symbol in password1)
            {
                if (char.IsLetter(symbol))
                {
                    letterCount++;
                }

                if (char.IsDigit(symbol))
                {
                    numberCount++;
                }
            }

            if (letterCount == 0 || numberCount == 0)
            {
                errors.Add("Passwords must contain both letters and numbers!");
            }
        }

        private static void ValidateEqual(string password1, string password2)
        {
            if (password1 != password2)
            {
                errors.Add("Password must be equal");
            }
        }

        private static void ValidateLength(string password1, string password2)
        {
            if (password1.Length < 8 || password2.Length < 8)
            {
                errors.Add("Password length must be at least 8!");
            }
        }
    }
}
