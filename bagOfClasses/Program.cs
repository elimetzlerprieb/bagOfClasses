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
            //bool rv = primeFactorFinder.findFactors(196);

            bool rv = primeFactorFinder.isPrimeV0(49);

            int A = primeFactorFinder.largestPrimeFactor();

            //var A = Math.Ceiling(Math.Sqrt(12));




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
