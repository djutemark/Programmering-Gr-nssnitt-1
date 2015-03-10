#include "stdafx.h"

using namespace std;

const int ANTAL = 510;

int main() {
	Lagenheter lista[ANTAL];

	for (int i = 0; i < ANTAL; i++) {
		Lagenheter temp;
		temp.Nummer(1000 + i);
		temp.Forbrukning(400 + i * 3);
		temp.Yta(50 + i);
		
		lista[i] = temp;
	}

	for (int i = 0; i < ANTAL; i++) {
		cout << "Nummer " << i << ": " << lista[i].Nummer() << endl;
	}

	return 0;
}