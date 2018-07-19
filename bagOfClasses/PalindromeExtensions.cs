using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public static class PalindromeExtensions
    {
        public static bool isPalindrome(this string str)
        {
            int forwardIterator = 0;
            int reverseIterator = str.Length - 1;

            while (forwardIterator < str.Length)
            {
                // iterators will only ever be equal if it is an odd length string
                // otherwise they will "pass" each other 
                if (forwardIterator == reverseIterator ||
                    forwardIterator > reverseIterator)
                {
                    return true;
                }

                if (str[forwardIterator] == str[reverseIterator])
                {
                    forwardIterator++;
                    reverseIterator--;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public static bool isPalindrome(this int number)
        {
            int[] result = number.ToString().Select(o => Convert.ToInt32(o)).ToArray();

            int forwardIterator = 0;
            int reverseIterator = result.Length - 1;

            while (forwardIterator < result.Length)
            {
                // iterators will only ever be equal if it is an odd length integer
                // otherwise they will "pass" each other 
                if (forwardIterator == reverseIterator ||
                    forwardIterator > reverseIterator)
                {
                    return true;
                }

                if (result[forwardIterator] == result[reverseIterator])
                {
                    forwardIterator++;
                    reverseIterator--;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }


}
