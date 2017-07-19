/**
 * This class provides serveral function for handling prime numbers.
 *
 * @author Sascha Schneider <foomy.code@arcor.de>
 *
 * @package Primes
 * @todo 09:56 <@cdTv> SirFoomy: du könntest deine Wurzel einfach mitwandern lassen: if (maxdivq < number) {maxdivq=maxdivq+2*maxdiv+1; maxdiv++}
 *		 09:58 <@cdTv> SirFoomy: wenn du die Primzahlen noch speicherst, brauchst du auch nur diese zum Testen verwenden
 */

#include <math.h>

class Primes
{
	private:
		int number;

	public:

		bool isPrime(int number)
		{
			int divisor,
				divisible,
				counter,
				rootOfNumber;

			// 1 isn't prime by definiton.
			if (number < 2) {
				return false;
			}

			//  Even numbers aren't prime too.
			if (number%2 == 0) { 
				return false;
			}

			divisor = 3;
			divisible = 0;

			rootOfNumber = static_cast<int>(round(sqrt(number)));
			do {
				if (number%divisor == 0) {
					divisible = 1;
				}
				divisor++;
			} while ( (divisible > 0) || (divisor <= rootOfNumber));

			if (divisible > 0) {
				return false;
			}

			return true;
		}

		int nextPrime(int number)
		{
			int prime = 0;
			int i = number+1;

			do {
				if (this->isPrime(i)) {
					prime = i;
				}
				i++;
			} while (prime == 0);

			return prime;
		}

		int previousPrime(int number)
		{
			int prime = 0;
			int i = number-1;

			do {
				if (this->isPrime(i)) {
					prime = i;
				}
				i--;
			} while (prime == 0);

			return prime;
		}
};
