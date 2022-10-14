# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>
# include "claseFecha.h"

using namespace std;

/// Clase base
class Persona {
protected:
    int _DNI;
    char _nombre[25], _apellido [25];
    /// Fecha _fechaNacimiento;
    Fecha _fechaNacimiento;
    int _telefono;
    char _mail [40];
public:
    /// Sets
    void setDNI(int DNI){_DNI=DNI;}
    void setNombre(const char *nombre){strcpy(_nombre,nombre);}
    void setApellido(const char *apellido){strcpy(_apellido,apellido);}
    void setFechaNacimiento(Fecha fechaNacimiento){_fechaNacimiento=fechaNacimiento;}

    /// Gets
    int getDNI(){return _DNI;}
    const char *getNombre(){return _nombre;}
    const char *getApellido(){return _apellido;}
    Fecha getFechaNacimiento(){return _fechaNacimiento;}

    void Cargar();
    void Mostrar();
    void cargarNacimiento(){_fechaNacimiento.Cargar();}
    void mostrarNacimiento(){_fechaNacimiento.Mostrar();}
};

void Persona::Cargar(){
    cout << "INGRESE DNI: ";
    cin >> _DNI;
    cout << "INGRESE EL NOMBRE: ";
    cin >> _nombre;
    cout << "INGRESE EL APELLIDO: ";
    cin >> _apellido;
    cout << "FECHA DE NACIMIENTO :" << endl;
    _fechaNacimiento.Cargar();
}

void Persona::Mostrar(){
    cout << "DNI: " << _DNI << endl;
    cout << "APELLIDO: " << _apellido << endl;
    cout << "NOMBRE: " << _nombre << endl;
    cout << "FECHA DE NACIMIENTO";
    _fechaNacimiento.Mostrar();

}

class Alumno:public Persona{
private:
    int _legajo;
    char _carrera[30];
public:
    /// Sets()
    void setCarrera(const char *carrera){strcpy_s(_carrera, carrera);}
    void setLegajo(int legajo){_legajo=legajo;}
    /// Gets()
    int getLegajo(){return _legajo;}
    const char *getCarrera(){return _carrera;}

    void ponerCeroDNI(){_DNI=0;}
    void Cargar();
    void Mostrar();
};

void Alumno::Cargar(){
    Persona::Cargar();
    char carrera [30];
    cout << "INGRESE EL NUMERO DE LEGAJO: ";
    cin >> _legajo;
    cout << "INGRESE EL NOMBRE DE LA CARRERA: ";
    cin >> carrera;
    strcpy_s(_carrera, carrera);
}
void Alumno::Mostrar(){
    Persona::Mostrar();
    cout << "NUMERO DE LEGAJO: " << _legajo << endl;
    cout << "NOMBRE DE LA CARRERA: " << _carrera;
}

class Docente:public Persona{
private:
    char _legajo[10];
public:
    const char *getLegajo(){return _legajo;}
    void setLegajo(const char *legajo){strcpy(_legajo,legajo);}
};

int main (){
	setlocale(LC_ALL, "");
    Alumno obj;
    obj.Cargar();
    obj.Mostrar();
	return 0;

}
