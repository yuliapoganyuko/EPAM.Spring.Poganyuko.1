using System;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        #region Public methods

        static void Main(string[] args)
        {
            int[] array = GetArray();
            MergeSort.Sort(array);
            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
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
