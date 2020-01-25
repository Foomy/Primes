using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Primes
    {
        public bool isPrime(long number)
        {
            long divisor;
            long sqrtOfNumber;
            Boolean divisible;
        
            // 1 is not prime by definition.
            if (number < 2) {
                return false;
            }

            if (2 == number) {
                return true;
            }

            // even numbers are also not prime.
            if (0 == number % 2) {
                return false;
            }

            divisor = 3;
            divisible = false;
            sqrtOfNumber = Convert.ToInt64(Math.Sqrt(number));

            do {
                if (0 == number % divisor) {
                    divisible = true;
                }

                divisor++;
            } while (divisible || divisor < sqrtOfNumber);

            return !divisible;
        }

        public long nextPrime(long number)
        {
            long nextPrime = number + 1;

            while (! isPrime(nextPrime)) {
                nextPrime++;
            }

            return nextPrime;
        }

        public long prevPrime(long number)
        {
            long prevPrime = number - 1;

            while (! isPrime(prevPrime) || prevPrime < 3) {
                prevPrime--;
            }

            return prevPrime;
        }
    }
}
