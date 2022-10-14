///Ejercicio:
///Autor:DEK
///Fecha:
///Comentario:

# include<iostream>
# include<cstdlib>
# include<cstring>

using namespace std;

class Persona{///clase base
protected:
    int DNI;
    char nombre[25], apellido[25];
public:
    ///gets
    int getDNI(){return DNI;}
    const char *getNombre(){return nombre;}
    const char *getApellido(){return apellido;}

    void setDNI(int d){DNI=d;}
    void setNombre(const char *n){strcpy(nombre,n);}
    void setApellido(const char *n){strcpy(apellido,n);}
};

class Alumno:public Persona{
private:
    int legajo;


public:
    int getLegajo(){return legajo;}
    void setLegajo(int l){legajo=l;}
    void ponerCeroDNI(){DNI=0;}

};

int main(){
    Alumno alu;
    alu.ponerCeroDNI();
	system("pause");
	return 0;
}
