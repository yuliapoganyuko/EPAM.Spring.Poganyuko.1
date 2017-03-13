using System;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        #region Public methods

        static void Main(string[] args)
        {
            int[] array = GetArray();
            Console.WriteLine($"Index of element with equal sums in the left and right sides: {IndexOfEqualSumsSearch.FindIndex(array)}");
            Console.ReadKey();
        }

        #endregion

        #region Private methods

        private static int[] GetArray()
        {
            Console.WriteLine("Enter the number of array elements:");
            int count = GetInt(true);

            int[] sortedArray = new int[count];

            Console.WriteLine("Enter array elements:");
            for (int index = 0; index < count; index++)
            {
                sortedArray[index] = GetInt(false);
            }
            return sortedArray;
        }

        private static int GetInt(bool isPositiveNumber)
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number) || (isPositiveNumber && number <= 0))
            {
                Console.WriteLine("Check your input");
            }
            return number;
        }

        #endregion
    }
}
