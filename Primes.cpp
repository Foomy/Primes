#include "Primes.h"

Primes::Primes(void)
	: number(1)
{
}

Primes::~Primes(void)
{
}

bool Primes::isPrime(int number)
{
	int divisor,
		divisible,
		rootOfNumber;

	// 1 isn't prime by definiton.
	if (number < 2) {
		return false;
	}

	//  Even numbers aren't prime too.
	if (number % 2 == 0) {
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
	} while ((divisible > 0) || (divisor <= rootOfNumber));

	if (divisible > 0) {
		return false;
	}

	return true;
}

int Primes::nextPrime(int number)
{
	int prime = 0;
	int i = number + 1;

	do {
		if (this->isPrime(i)) {
			prime = i;
		}
		i++;
	} while (prime == 0);

	return prime;
}

int Primes::previousPrime(int number)
{
	int prime = 0;
	int i = number - 1;

	do {
		if (this->isPrime(i)) {
			prime = i;
		}
		i--;
	} while (prime == 0);

	return prime;
}
