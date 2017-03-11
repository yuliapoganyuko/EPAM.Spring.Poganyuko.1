using System;
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

        private static string GetString()
        {
            Console.WriteLine("Enter the string");
            //string inputString = Console.ReadLine();
            return Console.ReadLine();
        }

        #endregion
    }
}
