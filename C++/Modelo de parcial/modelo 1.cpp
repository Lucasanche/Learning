# include<iostream>
# include<cstdlib>
# include<stdio.h>
# include<string.h>


using namespace std;


class JefeDeArea{
private:
    int _DNI;
    char _nombre[30];
    char _apellido[30];
public:
    int grabarEnDisco(int, const char*, const char *);
    int leerDeDisco(){
        FILE *p;
        p=fopen("JefesDeArea.dat","rb");
        if (p==NULL) return -1;
        while (fread(this, sizeof(JefeDeArea),1,p)){

            cout << "DNI: " << _DNI << endl;
            cout << "NOMBRE: " << _nombre << endl;
            cout << "APELLIDO: "<< _apellido << endl << endl;
        }
        fclose(p);
    }
};

void Punto1();


main (){
	setlocale(LC_ALL, "");
    JefeDeArea aux;
    int DNI;
    char nombre[30];
    char apellido[30];
    cin >> DNI;
    cin >> apellido;
    cin >> nombre;
    aux.grabarEnDisco(DNI, nombre, apellido);
    aux.leerDeDisco();
	return 0;

}


int JefeDeArea::grabarEnDisco(int DNI, const char *nombre, const char *apellido){
    FILE *p;
    _DNI=DNI;
    strcpy(_nombre, nombre);
    strcpy(_apellido, apellido);
    p=fopen("JefesDeArea.dat", "ab");
    if (p==NULL) return -1;
    bool escribio;
    escribio=fwrite(this, sizeof(JefeDeArea),1,p);
    fclose(p);
    return escribio;
}

void Punto1(){
    FILE *p, *c;
    p=fopen("Contratos.dat","rb");
    Contrato aux;
    Empleado emp;
    JefeDeArea reg;
    int pos=0;
    while(fread(aux, sizeof(Contrato),1,p)){
        if (aux.getFecha().getAnio()==2020){
            while(emp.leerDeDisco(pos)){
                if (emp.getDNI()==aux.getDNI()){
                    reg.grabarEnDisco(aux.getDNI(),aux.getNombre(),aux.getApellido());
                }
            }
        }
    }
}


///Resuelto

#include <iostream>
#include <cstring>

using namespace std;

class JefeDeArea2020{
    private:
        int dni;
        char nombre[30];
        char apellido[30];
    public:
        void setDni(int d){dni=d;}
        void setNombre(const char *n){strcpy(nombre, n);}
        void setApellido(const char *a){strcpy(apellido,a);}
        bool grabarEnDisco(){
            FILE *p=fopen("jefesarea2020.dat", "ab");
            if(p==NULL) return false;
            bool escribio=fwrite(this, sizeof *this, 1, p);
            fclose(p);
            return escribio;
        }
};

void punto1();
bool firmo2020(int d);
void punto2();
int buscarMaximo(int *v, int tam);

int main(){
    punto1();
    punto2();
    return 0;
}

///Generar un archivo con los Jefes de Área que hayan firmado contrato en el 2020 con el siguiente formato de registro:
///DNI, nombre y apellido.

void punto1(){
    Empleado reg;
    JefeDeArea2020 aux;
    int pos=0;
    while(reg.leerDeDisco(pos++)){
        if(reg.getCargo()==3){
            if(firmo2020(reg.getDni())){
                aux.setDni(reg.getDni());
                aux.setNombre(reg.getNombre());
                aux.setApellido(reg.getApellido());
                aux.grabarEnDisco();
            }
        }
    }
}

bool firmo2020(int d){
    Contrato reg;
    int pos=0;
    while(reg.leerDeDisco(pos++)){
        if(reg.getDni()==d && reg.getFechaContrato().getAnio() == 2020){
            return true;
        }
    }
    return false;
}

///Listar el mes con más contratos temporarios del año 2015.

void punto2(){
    Contrato reg;
    int pos=0, vMes[12]={};
    while(reg.leerDeDisco(pos++)){
        if(reg.getFechaContrato().getAnio()==2015 && reg.getTipoContrato()==1){
            vMes[reg.getFechaContrato().getMes()-1]++;
        }
    }
    cout<<"EL MES CON MAS CONTRATOS TEMPORARIOS DEL 2015 FUE: "<<buscarMaximo(vMes,12)+1;
}

int buscarMaximo(int *v, int tam){
    int posMax=0;
    for(int i=1; i<tam; i++){
        if(v[i]>v[posMax]){
            posMax=i;
        }
    }
    return posMax;
}

