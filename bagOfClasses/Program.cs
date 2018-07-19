using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Stack<long> factors = primeFactorFinder.GetPrimeFactors(196);
            long A = factors.Max();
            Console.WriteLine(A);

            //
            LargestPalindrome lp = new LargestPalindrome();
            long result = lp.Find(); 


            // static class doesn't require instantiation
            string output1 = StringReverse.WithBuffer("Elephant");
            string output2 = StringReverse.InPlace("AARDVRK");


            // palindrome tester 
            string pteststring = "123321";
            bool prc = pteststring.IsPalindrome();

            int ptestint = 123321;
            bool irc = ptestint.IsPalindrome();



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
