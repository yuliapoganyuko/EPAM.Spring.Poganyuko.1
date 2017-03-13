using System;
using System.Text.RegularExpressions;
using Task4Logic;

namespace Task4Console
{
    class Program
    {
        #region Public methods

        static void Main(string[] args)
        {
            string firstString = GetString();
            string secondString = GetString();
            Console.WriteLine(
                $"Concatenated string: {StringsConcatenator.ConcatenateStrings(firstString, secondString)}");
            Console.ReadKey();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Methog gets the string consisting of symbols from 'a' to 'z' using console.
        /// </summary>
        /// <returns>The string consisting of symbols from 'a' to 'z' in lower case.</returns>
        private static string GetString()
        {
            Console.WriteLine("Enter the string");
            string inputString;
            while (!Regex.IsMatch(inputString = Console.ReadLine(), @"^[a-zA-Z]+$"))
                Console.WriteLine("The string should contain only symbols from 'a' to 'z'");
            return inputString.ToLower();
        }

        #endregion
    }
}
