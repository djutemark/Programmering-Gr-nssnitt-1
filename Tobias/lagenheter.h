#pragma once
class Lagenheter
{
private:
	int nummer, yta, forbrukning;
public:



#pragma region Setters & Getters
	int Nummer();
	int Yta();
	int Forbrukning();

	void Nummer(int x);
	void Yta(int x);
	void Forbrukning(int x);
#pragma endregion
};

