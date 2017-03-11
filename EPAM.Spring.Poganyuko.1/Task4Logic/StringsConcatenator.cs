using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    public static class StringsConcatenator
    {
        #region Public methods

        public static string ConcatenateStrings(string string1, string string2)
        {
            if (string1 == null || string2 == null)
                throw new ArgumentNullException();
            //is it needed to check if strings are not empty?
            char[] charsArray = string.Concat(string1, string2).Distinct().ToArray();
            Array.Sort(charsArray);
            return new string(charsArray);
        }

        #endregion

        #region Private methods



        #endregion
    }
}
