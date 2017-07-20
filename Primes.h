/**
 * This class provides serveral function for handling prime numbers.
 *
 * @author Sascha Schneider <foomy.code@arcor.de>
 *
 * @package Primes
 * @todo 09:56 <@cdTv> SirFoomy: du könntest deine Wurzel einfach mitwandern lassen: if (maxdivq < number) {maxdivq=maxdivq+2*maxdiv+1; maxdiv++}
 *		 09:58 <@cdTv> SirFoomy: wenn du die Primzahlen noch speicherst, brauchst du auch nur diese zum Testen verwenden
 */

#pragma once
#include <math.h>

class Primes
{
private:
	int number;

public:
	explicit Primes(void);
	virtual ~Primes(void);

	bool isPrime(int number);
	int nextPrime(int number);
	int previousPrime(int number);
};
