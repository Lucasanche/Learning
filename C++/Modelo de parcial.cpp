# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>
#include "Fecha.h"


class JefeArea2020{
private:
    int DNI;
    char nombre[30];
    char apellido[30];
public:
    void Cargar(int, const char *, const char*);
    void Mostrar();

};
void JefeArea2020::Cargar(int _DNI, const char *_nombre, const char *_apellido){
    this->DNI=DNI;
    strcpy(apellido, _apellido);
    strcpy(nombre, _nombre);
}
void JefeArea2020::Mostrar(){
    cout << "DNI: " << DNI << endl;
    cout << "NOMBRE: " << nombre << endl;
    cout << "APELLIDO: " << apellido  << endl;
}

using namespace std;
void Punto1();

main (){
	setlocale(LC_ALL, "");

	return 0;

}

void Punto1(){
    FILE *p=fopen("contratos.dat","rb");

}
