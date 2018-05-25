using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public static class StringReverse
    {
        public static string inPlace(string input)
        {
            char[] workingArray = input.ToCharArray();

            int front = 0;
            int back = workingArray.Length - 1;
            char temp;

            while (front < back)
            {
                temp = workingArray[front];

                workingArray[front] = workingArray[back];
                workingArray[back] = temp;

                front++;
                back--;
            }

            string output = new string(workingArray);
            return output;
        }

        public static string withBuffer(string inputString)
        {
            StringBuilder reversed = new StringBuilder("");

            for (int i = inputString.Length - 1; i >= 0; i--)
            {    
                reversed.Append(inputString[i]);
            }

            return reversed.ToString();
        }
    }
}
