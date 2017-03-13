using System;

namespace Task1Logic
{
    /// <summary>
    /// Class provides functionality of searching for maximal element of array recursively
    /// </summary>
    public static class MaximalElementOfArray
    {
        #region Public Methods

        /// <summary>
        /// Method searches for maximal element of array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Index of the maximal element in array</returns>
        public static int GetMaximalElement(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            return GetMax(array, 0, array.Length - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Method recursively searches for maximal element in array's part. Part is marked by indexes 
        /// of first and last positions of part in array. 
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="firstPosition">Index of first position for searching in array</param>
        /// <param name="lastPosition">Index of last position for searching in array</param>
        /// <returns></returns>
        private static int GetMax(int[] array, int firstPosition, int lastPosition)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (firstPosition < 0 || firstPosition > array.Length-1 || firstPosition > lastPosition
                || lastPosition < 0 || lastPosition > array.Length - 1)
                throw new ArgumentOutOfRangeException();

            if (firstPosition == lastPosition)
                return array[firstPosition];
            
            if ((firstPosition - lastPosition) == 1 || (lastPosition - firstPosition) == 1)
            {
                if (array[firstPosition] > array[lastPosition])
                    return array[firstPosition];
                return array[lastPosition];
            }

            int middlePosition = (firstPosition + lastPosition) / 2;
            
            int leftMax = GetMax(array, firstPosition, middlePosition);
            int rightMax = GetMax(array, middlePosition + 1, lastPosition);
            
            if (leftMax > rightMax)
                return leftMax;
            return rightMax;
        }

        #endregion
    }
}
