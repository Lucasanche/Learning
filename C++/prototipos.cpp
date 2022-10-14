# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>

using namespace std;

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
main (){
	setlocale(LC_ALL, "");
    JefeArea2020 aux;
    int a=34234;
    char nom[30]="lucas";
    char ape[30]="sanchez";
    aux.Cargar(a, nom, ape);
    aux.Mostrar();
	return 0;

}
