# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>

using namespace std;

class Fecha {
private:
    int _dia, _mes, _anio;
public:
    Fecha(int dia=0, int mes=0, int anio=0){
        _dia=dia;
        _mes=mes;
        _anio=anio;
    }
    void setDia(int dia){_dia=dia;}
    void setMes(int mes){if (mes<=12 && mes>=1)_mes=mes;}
    void setAnio(int anio){_anio=anio;}

    int getDia(){return _dia;}
    int getMes(){return _mes;}
    int getAnio(){return _anio;}

    void Mostrar();
    void Cargar();
};

void Fecha::Mostrar(){
    cout << _dia << "/" << _mes << "/" << _anio << endl;
}
void Fecha::Cargar(){
    int dia, mes, anio;
    cout << "DIA: ";
    cin >> dia;
    setDia(dia);
    cout << "MES: ";
    cin >> mes;
    setMes(mes);
    cout << "AÑO: ";
    cin >> anio;
    setAnio(anio);
}

