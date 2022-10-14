// pruebacopiadodevectores.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<vector>

void pruebaVector(int test2[]) {
    int test[3] = { 3, 4, 5 };
    for (int i = 0; i < 3; i++) {
        test2[i] = test[i];
    }
    
}

int main()
{   
    std::string string;
    string += "chocha\n";
    string += "culo\n";
    string += "teta\n";
    std::cout << string;
}
