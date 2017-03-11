using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    public class StringsConcatenator
    {
        #region Public methods

        public static string ConcatenateStrings(string string1, string string2)
        {
            if (string1 == null || string2 == null)
                throw new ArgumentNullException();
            string resultString = string.Empty;
            //is it needed to check if strings are empty?
            for (char literal = 'a'; literal <= 'z'; literal++)
            {
                if (string1.Contains(literal) || string2.Contains(literal))
                    resultString.Insert(resultString.Length, literal.ToString());
            }
            return resultString;
        }

        #endregion

        #region Private methods



        #endregion
    }
}
