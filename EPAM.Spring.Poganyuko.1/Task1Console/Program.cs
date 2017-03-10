using System;
using Task1Logic;

namespace Task1Console
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = GetArray();
            Console.WriteLine(MaximalElementOfArray.GetMaximalElement(array));
            Console.ReadKey();
        }

        private static int[] GetArray()
        {
            Console.WriteLine("Enter the number of array elements:");
            int count = GetInt();

            int[] sortedArray = new int[count];

            Console.WriteLine("Enter array elements:");
            for (int index = 0; index < count; index++)
            {
                sortedArray[index] = GetInt();
            }
            return sortedArray;
        }
        
        private static int GetInt()
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("You've entered not a number");
            }
            return number;
        }
    }
    
}
