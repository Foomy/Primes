#include "Primes.h"

Primes::Primes(void)
	: number(1)
{
}

Primes::~Primes(void)
{
}

bool Primes::isPrime(PrimeDataType number)
{
	// 1 isn't prime by definiton.
	if (2 > number)
	{
		return false;
	}

	//  Even numbers aren't prime too.
	if (0 == number % 2)
	{
		return false;
	}

	PrimeDataType divisor = 3;
	PrimeDataType divisible = 0;
	PrimeDataType rootOfNumber = static_cast<PrimeDataType>(round(sqrt(number)));

	do
	{
		if (0 == number % divisor)
		{
			divisible = 1;
		}
		divisor++;
	} while ((0 == divisible) && (rootOfNumber > divisor));

	if (divisible > 0) {
		return false;
	}

	return true;
}

PrimeDataType Primes::nextPrime(PrimeDataType number)
{
	PrimeDataType prime = 0;
	PrimeDataType i = number + 1;

	do
	{
		if (this->isPrime(i))
		{
			prime = i;
		}
		i++;
	} while (prime == 0);

	return prime;
}

PrimeDataType Primes::previousPrime(PrimeDataType number)
{
	PrimeDataType prime = 0;
	PrimeDataType i = number - 1;

	do
	{
		if (this->isPrime(i))
		{
			prime = i;
		}
		i--;
	} while (prime == 0);

	return prime;
}
