using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    /// <summary>
    /// Class providing functionality of concatinating strings. Input strings should contain only symbols from 'a' 
    /// to 'z'. The resulting string includes all unique symbols from input strings sorted by alphabetical order 
    /// without duplicating.
    /// </summary>
    public static class StringsConcatenator
    {
        #region Public methods

        /// <summary>
        /// Method concatenates two strings.
        /// </summary>
        /// <param name="firstString">First input string. Should contain only symbols from 'a' to 'z'.</param>
        /// <param name="secondString">Second input string. Should contain only symbols from 'a' to 'z'.</param>
        /// <returns>String includes all unique symbols from input strings sorted by alphabetical order 
        /// without duplicating.</returns>
        public static string ConcatenateStrings(string firstString, string secondString)
        {
            if (firstString == null || secondString == null)
                throw new ArgumentNullException();
            if (firstString == string.Empty || secondString == string.Empty)
                throw new ArgumentException();
            char[] charsArray = string.Concat(firstString, secondString).Distinct().ToArray();
            Array.Sort(charsArray);
            return new string(charsArray);
        }

        #endregion
        
    }
}
