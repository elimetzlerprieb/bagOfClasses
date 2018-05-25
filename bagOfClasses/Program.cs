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
            Stack<long> factors = primeFactorFinder.getPrimeFactors(196);
            long A = factors.Max();
            Console.WriteLine(A);


            // static class doesn't require instantiation
            string output1 = StringReverse.withBuffer("Elephant");
            string output2 = StringReverse.inPlace("AARDVRK");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
