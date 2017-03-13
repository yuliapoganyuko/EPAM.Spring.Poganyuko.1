using System;

namespace Task2Logic
{
    /// <summary>
    /// Class for search for the index of equal sums of elements on the left side and on the right side of the index.
    /// </summary>
    public static class IndexOfEqualSumsSearch
    {
        #region Public methods

        /// <summary>
        /// Method searches for the index of equal sums of elements on the left side and on the right side of the index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>The index of equal sums.</returns>
        public static int FindIndex(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            int totalSum = 0;
            for (int i = 0; i < array.Length; i++)
                totalSum += array[i];

            int currentRightSum = totalSum;
            int currentLeftSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentRightSum -= array[i];
                if (currentLeftSum == currentRightSum)
                    return i;
                currentLeftSum += array[i];
            }

            return -1;
        }

        #endregion
        
    }
}
