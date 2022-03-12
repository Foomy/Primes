using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Primes
    {
        private const int DIVISION_START_NUMBER = 3;

        public bool isPrime(ulong number)
        {
            ulong divisor;
            ulong sqrtOfNumber;
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

            divisor = DIVISION_START_NUMBER;
            divisible = false;
            sqrtOfNumber = (ulong)Math.Ceiling(Math.Sqrt(number));

            while (divisor <= sqrtOfNumber) {
                if (0 == number % divisor) {
                    divisible = true;
                    break;
                }

                divisor++;
            };

            return !divisible;
        }

        public ulong nextPrime(ulong number)
        {
            ulong nextPrime = number + 1;

            while (!isPrime(nextPrime)) {
                nextPrime++;
            }

            return nextPrime;
        }

        public ulong prevPrime(ulong number)
        {
            ulong prevPrime = number;
            Boolean prevPrimeFound = isPrime(prevPrime);

            while (!prevPrimeFound) {
                prevPrime--;
                prevPrimeFound = isPrime(prevPrime);
            };

            return prevPrime;
        }
    }
}
