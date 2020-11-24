// C++ Rot-13 Verschlüsselung.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int GroßKlein(char buchstabe, char großBuchstaben[], char kleinBuchstaben[]) {
    for (int y = 0; y < 26; y++) {
        if (buchstabe == kleinBuchstaben[y]) {
            return 1;
        }
    }
    for (int z = 0; z < 26; z++) {
        if (buchstabe == großBuchstaben[z]) {
            return 2;
        }
    }
    return 0;
}

int main()
{
    std::string eingabe;
    std::cout << "Bitte Wort eingeben: ";
    std::cin >> eingabe;
    std::cout << std::endl;

    const int eingabeLength = 10; // eingabe.length();
    char eingabeCharArray[eingabeLength];
    for (int i = 0; i < eingabeLength; i++) {
        eingabeCharArray[i] = eingabe[i];
    }

    //eingabeCharArray[] = eingabe;
    //strcpy_s(eingabeCharArray, eingabe.c_str());

    int verschiebung;
    std::cout << "Verschieben um: ";
    std::cin >> verschiebung;
    std::cout << std::endl;

    char ausgabe[eingabeLength];
    char buchstabe;
    int buchstabeNummer;
    char großBuchstaben[26] = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    char kleinBuchstaben[26] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    int column;

    int q = 0;

    for (int x = 0; x < eingabeLength; x++) {
        buchstabe = eingabeCharArray[x];

        column = GroßKlein(buchstabe, großBuchstaben, kleinBuchstaben);
        if (column == 2) {
            buchstabeNummer = (int)buchstabe - 65 + verschiebung;
            if (buchstabeNummer < 0) {
                buchstabeNummer += 26;
            }
            else if (buchstabeNummer > 25) {
                buchstabeNummer -= 26;
            }
            buchstabe = großBuchstaben[buchstabeNummer];
        }
        else if (column == 1) {
            buchstabeNummer = (int)buchstabe - 97 + verschiebung;
            if (buchstabeNummer < 0) {
                buchstabeNummer += 26;
            }
            else if (buchstabeNummer > 25) {
                buchstabeNummer -= 26;
            }
            buchstabe = kleinBuchstaben[buchstabeNummer];
        }

        eingabeCharArray[x] = buchstabe;
    }

    std::cout << std::endl << "Ausgabe: ";  
    while (q < eingabeLength) {
        std::cout << eingabeCharArray[q];
        q++;
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
