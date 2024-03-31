using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFun {
    internal class PrimeNumbers {
        public static Boolean IsPrime(long num) {
            if (num == 2)     { return true;  }
            if (num == 3)     { return true;  }
            if (num % 2 == 0) { return false; }

            for (int i = 3; i <= Math.Sqrt(num); i += 2) {
                if (num % i == 0) { return false; }
            }
            return true;    
        }
    }
}
