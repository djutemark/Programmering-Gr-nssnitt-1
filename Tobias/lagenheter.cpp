#include "stdafx.h"
#include "lagenheter.h"

int Lagenheter::Nummer() {
	return nummer;
}
int Lagenheter::Yta() {
	return yta;
}
int Lagenheter::Forbrukning() {
	return forbrukning;
}

void Lagenheter::Nummer(int x) {
	nummer = x;
}
void Lagenheter::Yta(int x) {
	yta = x;
}
void Lagenheter::Forbrukning(int x) {
	forbrukning = x;
}