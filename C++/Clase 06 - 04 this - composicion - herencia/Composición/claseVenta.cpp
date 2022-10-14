# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>


using namespace std;

///Clase Fecha
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


class Venta {
private:
    int _numero, _codigoArticulo, _cantidad;
    float _importe;
    Fecha _fechaVenta;
public:
    void Cargar();
    void Mostrar();
    void setFechaVenta(Fecha fechaVenta){_fechaVenta=fechaVenta;}
    /// int getFechaVenta(){_fechaVenta.Mostrar();}
    Fecha getFechaVenta(){return _fechaVenta;}
};

void Venta::Cargar(){
    cout << "NUMERO DE VENTA: ";
    cin >> _numero;
    cout << "ARTICULO: ";
    cin >> _codigoArticulo;
    cout << "CANTIDAD: ";
    cin >> _cantidad;
    cout << "IMPORTE: ";
    cin >> _importe;
    _fechaVenta.Cargar();
}

void Venta::Mostrar(){
    cout << "NUMERO DE VENTA: " << _numero << endl;
    cout << "ARTICULO: " << _codigoArticulo << endl;
    cout << "CANTIDAD: " << _cantidad << endl;
    cout << "IMPORTE: " << _importe << endl;
    _fechaVenta.Mostrar();
}

main (){
	setlocale(LC_ALL, "");
	int dia, mes, anio;
	Fecha diaActual;
    Venta coso;
    coso.Cargar();
    coso.Mostrar();
    diaActual.Cargar();
    coso.setFechaVenta(diaActual);
    coso.getFechaVenta().Mostrar();
	return 0;

}
