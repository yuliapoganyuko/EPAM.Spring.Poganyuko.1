﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    public static class MergeSort
    {
        #region Public methods

        public static int[] Sort(int[] array)
        {
            
        }

        #endregion

        #region Private methods

        private static int[] Sort(int[] array, int firstPosition, int lastPosition)
        {
            if (firstPosition < lastPosition)
            {
                int middlePosition = (firstPosition + lastPosition) / 2;
                int[] leftPart = Sort(array, firstPosition, middlePosition);
                int[] rightPart = Sort(array, middlePosition + 1, lastPosition);
                Merge(array, firstPosition, middlePosition, lastPosition);
            }
            return array;
        }

        private static int[] Merge(int[] array, int firstPosition, int middlePosition, int lastPosition)
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
            return array;
        }

        #endregion
    }
}