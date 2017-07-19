#include <iostream>
#include <cstdlib>
#include <math.h>

#include "Primes.h"

using namespace std;

int main(int argc, char *argv[])
{
	int number;
	Primes prim;

	if (argc <= 1) {
		cout << "Usage: isPrime <unsigned integer>" << endl;
		return -1;	
	}

	number = atoi(argv[1]);
	if (number < 1) {
		cout << "Usage: isPrime <unsigned integer>" << endl;
		return -1;
	}

	if (! prim.isPrime(number)) {
		cout << number << " isn't prime.";
		return 0;
	}

	cout << number << " is prime.";
	return 1;
}
