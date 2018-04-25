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

            
            bool rc = false;

            int A = 2;

            rc = primeFactorFinder.isPrime(A);
            if (rc != true)
            {
                Console.WriteLine("Test 1 Failed");
            }
            else
            {
                Console.WriteLine("Test 1 Passed");
            }

            A = 4;
            rc = primeFactorFinder.isPrime(A);
            if (rc != false)
            {
                Console.WriteLine("Test 2 Failed");
            }
            else
            {
                Console.WriteLine("Test 2 Passed");
            }

            A = 13;
            rc = primeFactorFinder.isPrime(A);
            if (rc != true)
            {
                Console.WriteLine("Test 3 Failed");
            }
            else
            {
                Console.WriteLine("Test 3 Passed");
            }




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


















        }
    }
}
