// C++ Testing.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
#include <chrono>
using namespace std;

int main()
{
    cout << "Please type in a random number.\n";
    int eingabe;
    cin >> eingabe;

    auto start = std::chrono::high_resolution_clock::now();

    unsigned long long int allnums = 2;
    double max;
    bool prime;
    
    for (int i = 1; i < eingabe; i += 2) {
        max = sqrt(i);
        prime = true;

        for (int i2 = 3; i2 <= max; i2 += 2) {
            if (i % i2 == 0) {
                prime = false;
                break;
            }
        }

        if (prime) {
            allnums += i;
        }
    }

    auto finish = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double> elapsed = finish - start;
    std::cout << "Elapsed time: " << elapsed.count() << " s\n";

    cout << endl << allnums;

    return 0;
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
