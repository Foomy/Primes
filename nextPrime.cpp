#include <iostream>
#include <cstdlib>
#include <math.h>
#include "Primes.h"

int main(int argc, char *argv[])
{
	int number;
	Primes prim;

	number = atoi(argv[1]);
	if (argc > 1) {
		if (number < 1) {
			std::cout << "Usage: isPrime <unsigned integer>" << std::endl;
			return 0;
		}
	}
	else {
		std::cout << "Usage: isPrime <unsigned integer>" << std::endl;
		return 0;
	}

	std::cout << prim.nextPrime(number);
	return 1;
}
