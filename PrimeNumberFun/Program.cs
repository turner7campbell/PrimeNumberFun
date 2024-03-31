/*
 * Prime Number Fun
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFun {
    internal class Program {
        static void Main(string[] args)
        {
            int passCount = 0, failCount = 0;
            long[] test = new long[]           {   2,     3,     4,    5,     6,    7,     8,     9,    10,   11 };
            Boolean[] expected = new Boolean[] { true, true, false, true, false, true, false, false, false, true };
            for (int i = 0; i < test.Length; i++) {
                Console.Write(test[i] + ": " + PrimeNumberFun.PrimeNumbers.IsPrime(test[i]));
                if (PrimeNumbers.IsPrime(test[i]) != expected[i])
                {
                    Console.WriteLine("FAILED"); 
                    failCount++;
                } else { Console.WriteLine(""); passCount++; }
            }
            Console.WriteLine("Passed: " + passCount);
            Console.WriteLine("Failed: " + failCount);
        }
    }
}
