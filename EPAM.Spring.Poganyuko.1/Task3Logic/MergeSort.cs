using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    /// <summary>
    /// Class provides functionality of merge sort
    /// </summary>
    public static class MergeSort
    {
        #region Public methods

        /// <summary>
        /// Method sorts array
        /// </summary>
        /// <param name="array">Input array</param>
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Method sorts array dividing it into parts. Part is determined by first and last positions in array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="firstPosition">Index of first position of part in input array</param>
        /// <param name="lastPosition">Index of last position of part in input array</param>
        private static void Sort(int[] array, int firstPosition, int lastPosition)
        {
            if (firstPosition < lastPosition)
            {
                int middlePosition = (firstPosition + lastPosition) / 2;
                Sort(array, firstPosition, middlePosition);
                Sort(array, middlePosition + 1, lastPosition);
                Merge(array, firstPosition, middlePosition, lastPosition);
            }
        }

        /// <summary>
        /// Method merges two successive sorted parts of array. 
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="firstPosition">Index of first position of first part to merge in input array</param>
        /// <param name="middlePosition">Index of last position of first part to merge in input array</param>
        /// <param name="lastPosition">Index of last position of second part to merge in input array</param>
        private static void Merge(int[] array, int firstPosition, int middlePosition, int lastPosition)
        {
            int[] temporaryArray = new int[array.Length];

            for (int i = firstPosition; i <= lastPosition; i++)
                temporaryArray[i] = array[i];

            int currentLeft = firstPosition, currentRight = middlePosition + 1;
            int currentPosition = firstPosition;

            while (currentLeft <= middlePosition && currentRight <= lastPosition)
            {
                if (temporaryArray[currentLeft] <= temporaryArray[currentRight])
                {
                    array[currentPosition] = temporaryArray[currentLeft];
                    currentLeft++;
                }
                else
                {
                    array[currentPosition] = temporaryArray[currentRight];
                    currentRight++;
                }
                currentPosition++;
            }

            int remaining = middlePosition - currentLeft;
            for (int i = 0; i <= remaining; i++)
                array[currentPosition + i] = temporaryArray[currentLeft + i];
        }

        #endregion
    }
}
