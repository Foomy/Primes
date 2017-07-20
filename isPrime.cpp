#include <iostream>
#include <cstdlib>
#include <math.h>
#include "Primes.h"

int main(int argc, char *argv[])
{
	int number;
	Primes prim;

	if (argc <= 1) {
		std::cout << "Usage: isPrime <unsigned integer>" << std::endl;
		return -1;
	}

	number = atoi(argv[1]);
	if (number < 1) {
		std::cout << "Usage: isPrime <unsigned integer>" << std::endl;
		return -1;
	}

	if (!prim.isPrime(number)) {
		std::cout << number << " isn't prime.";
		return 0;
	}

	std::cout << number << " is prime.";
	return 1;
}
