# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>
# include "Fecha.h"

using namespace std;

class Alumno {
private:
    int _legajo;
    char _nombre[25];
    char _apellido[25];
    char _email[30];
    Fecha _fechaNacimiento;
    int _codigoCarrera;
    bool estado; // se usa para indicar si el registro está activo o no
public:
    /// Sets()
    void setLegajo(int legajo){_legajo=legajo;}
    void setNombre (const char *nombre){strcpy(_nombre,nombre);}
    void setApellido (const char *apellido){strcpy(_apellido,apellido);}
    void setNacimiento (Fecha fechaNacimiento){_fechaNacimiento=fechaNacimiento;}
    void setEmail (const char *email){strcpy(_email,email);}
    void setCodigoCarrera(int codigoCarrera){_codigoCarrera=codigoCarrera;}
    /// Gets()
    int getLegajo(){return _legajo;}
    const char *getNombre(){return _nombre;}
    const char *getApellido (){return _apellido;}
    Fecha getNacimiento (){return _fechaNacimiento;}
    const char *getEmail (){return _email;}
    int getCodigoCarrera(){return _codigoCarrera;}

    ///Métodos
    void Cargar();
    void Mostrar();
};
void Alumno::Cargar(){
    cout << "NOMBRE: ";
    cin >> _nombre;
    cout << "APELLIDO: ";
    cin >> _apellido;
    cout << "FECHA DE NACIMIENTO" << endl;
    _fechaNacimiento.Cargar();
    cout << "EMAIL: ";
    cin >> _email;
    cout << "CODIGO DE LA CARRERA: ";
    cin >> _codigoCarrera;
    cout << "LEGAJO: ";
    cin >> _legajo;
}
void Alumno::Mostrar(){
    cout << "NOMBRE: " << _nombre << endl;
    cout << "APELLIDO: " <<_apellido << endl;
    cout << "FECHA DE NACIMIENTO: ";
    _fechaNacimiento.Mostrar();
    cout << "EMAIL: " << _email << endl;
    cout << "CODIGO DE LA CARRERA: " << _codigoCarrera << endl;
    cout << "LEGAJO: " << _legajo << endl;
}
/// Prototipos ///
int grabarRegistro(Alumno);
void leerRegistro();

main (){
	setlocale(LC_ALL, "");
    Alumno alumno;
    int opc;
    /// Menú ///
    while (true){
        cout << "   MENU DE ALUMNOS" << endl;
        cout << endl;
        cout << "   1 - CARGAR REGISTRO" << endl;
        cout << "   2 - MOSTRAR REGISTRO" << endl;
        cout << "   0 - SALIR"<< endl;
        cout << endl;
        cout << "Ingrese una opción: ";
        cin >> opc;
        switch (opc){
        case 1:
            alumno.Cargar();
            if (grabarRegistro(alumno)==1)cout << "REGISTRO AGREGADO"<<endl;
            else cout << "REGISTRO NO AGREGADO"<<endl;
            system("pause");
            break;
        case 2:
            leerRegistro();
            break;
        case 0:
            return 0;
            break;
        }
        system("cls");
    }


}

int grabarRegistro(Alumno alumno){
    char nombreArchivo[20];
    FILE *pAlumnos;
    cout << "Ingrese el nombre del archivo: ";
    cin >> nombreArchivo;
    pAlumnos=fopen(nombreArchivo, "ab");
    fread()
    if(pAlumnos==NULL){
        cout << "No se pudo abrir el archivo" <<endl;
        system("pause");
        return -1;
    }
    int escribio=fwrite(&alumno, sizeof alumno,1,pAlumnos);
    fclose(pAlumnos);
    return escribio;
}
void leerRegistro(){
    char nombreArchivo[20];
    Alumno alumno;
    FILE *pAlumnos;
    cout << "Ingrese el nombre del archivo: ";
    cin >> nombreArchivo;
    cout << endl;
    pAlumnos=fopen(nombreArchivo, "rb");
    if(pAlumnos==NULL){
        cout << "No se pudo abrir el archivo" <<endl;
        system("pause");
        return;
    }
    while (fread(&alumno, sizeof alumno,1, pAlumnos)){
        alumno.Mostrar();
        cout << endl;
    }
    fclose(pAlumnos);
    system("pause");
}
