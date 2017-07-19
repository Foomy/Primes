#include <iostream>
#include <cstdlib>
#include <math.h>

#include "Primes.h"

using namespace std;

int main(int argc, char *argv[])
{
	int number;
	Primes prim;

	number = atoi(argv[1]);
	if (argc > 1) {
		if (number < 1) {
			cout << "Usage: isPrime <unsigned integer>" << endl;
			return 0;
		}
	} else {
		cout << "Usage: isPrime <unsigned integer>" << endl;
		return 0;
	}

	cout << prim.nextPrime(number);
	return 1;
}