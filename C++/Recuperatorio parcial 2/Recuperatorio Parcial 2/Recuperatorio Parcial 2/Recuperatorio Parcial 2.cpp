#include <iostream>
#include <string.h>
#include "parcial2.h"

using namespace std;

// Punto 1

class AuxPunto1
{
private:
	char _codigoVuelo[5];
	char _nombre[30];
	int _cantidadPasajes;
public:
    int grabarEnDisco() {
        FILE* p;
        p = fopen("Punto1.dat", "ab");
        if (p == NULL) return -1;
        int grabo = fwrite(this, sizeof * this, 1, p);
        fclose(p);
        return grabo;
    }
    void setCodigoVuelo(const char* codigoVuelo) { strcpy(_codigoVuelo, codigoVuelo); }
    void setNombre(const char* nombre) { strcpy(_nombre, nombre); }
    void setCantidadPasajes(int cantidadPasajes) { _cantidadPasajes = cantidadPasajes; }
};

int contarPasajes(const char* codigoVuelo) {
    int contadorPasajes = 0;
    int pos = 0;
    Pasaje regPasaje;
    while (regPasaje.leerDeDisco(pos++) == 1) {
        if (strcmp(codigoVuelo, regPasaje.getCodigoVuelo()) == 0) {
            contadorPasajes++;
        }
    }
    return contadorPasajes;
}
void Punto1(){
    AuxPunto1 punto1;
    Vuelo regVuelo;
    int pos1 = 0;
    while (regVuelo.leerDeDisco(pos1++) == 1) {
        punto1.setCodigoVuelo(regVuelo.getCodigoVuelo());
        punto1.setNombre(regVuelo.getNombre());
        punto1.setCantidadPasajes(contarPasajes(regVuelo.getCodigoVuelo()));
        punto1.grabarEnDisco();
    }
}

//Punto 2

int calculoDestinoMenosVuelos() {
    Vuelo regVuelo;
    int pos = 0;
    int minimo = 0;
    int destMinimo = 0;
    int cantidadDestinos = 100;
    int* vContadorDestino = new int[cantidadDestinos];
    bool flagMin = true;
    for (int i = 0; i < cantidadDestinos; i++) {
        vContadorDestino[i] = 0;
    }
    if (vContadorDestino == NULL){
        return -1;
    }
    while (regVuelo.leerDeDisco(pos++) == 1) {
        vContadorDestino[regVuelo.getDestino()-1]++;
    }
    for (int i = 0; i < cantidadDestinos; i++) {
        if (vContadorDestino[i] != 0) {
            if (flagMin) {
                minimo = vContadorDestino[i];
                destMinimo = i + 1;
                flagMin = false;
            }
            else if (vContadorDestino[i] < minimo) {
                minimo = vContadorDestino[i];
                destMinimo = i + 1;
            }
        }
    }
    delete[] vContadorDestino;
    return destMinimo;
}

void Punto2() {
    int aux = calculoDestinoMenosVuelos();
    if (aux == -1) {
        cout << "Error al calcular" << endl;
    }
    else if (aux == 0) {
        cout << "No hay destinos" << endl;
    }
    else {
        cout << "El destino con la menor cantidad de vuelos es el numero: " << aux << endl;
    }
}

//Punto 3

int contarPasajeros() {
    Pasajero regPasajero;
    int pos = 0;
    while (regPasajero.leerDeDisco(pos) == 1) {
        pos++;
    }
    return pos;
}

void Punto3() {
    int numeroIngresado;
    int cantPasajeros = contarPasajeros();
    Pasajero* regPasajero = new Pasajero[cantPasajeros];
    cout << "ingrese un numero de provincia: ";
    cin >> numeroIngresado;
    for (int i = 0; i < cantPasajeros; i++) {
        if (regPasajero[i].getProvincia() != numeroIngresado) {
            regPasajero[i].Mostrar();
            cout << endl;
        }
    }
}

int main()
{
    Punto1();
    Punto2();
    Punto3();
    //Punto 4:
    //bool Vuelo::operator==(Vuelo& aux) {
    //    if (aux.getTiempoViaje() == tiempoViaje) {
    //        return true;
    //    }
    //    else { return false; }
    //}
    system("pause");
    return 0;
}
