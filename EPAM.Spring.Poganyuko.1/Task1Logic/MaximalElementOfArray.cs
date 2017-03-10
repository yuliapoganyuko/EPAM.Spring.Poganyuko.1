using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    public static class MaximalElementOfArray
    {
        #region Public Method

        public static int GetMaximalElement(int[] array)
        {
            return GetMax(array, Int32.MinValue);
        }

        #endregion

        #region Private Method

        private static int GetMax(int[] array, int largest)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array[0] > largest)
                largest = array[0];
            if (array.Length != 1)
            {
                int[] newArray = new int[array.Length - 1];
                Array.Copy(array, 1, newArray, 0, array.Length - 1);
                array = newArray;
                largest = GetMax(array, largest);
            }
            return largest;
        }

        #endregion
    }
}
