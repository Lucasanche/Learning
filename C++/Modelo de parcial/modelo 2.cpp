# include<iostream>
# include<cstdlib>
# include<cstring>
# include <windows.h>
# include <wchar.h>

using namespace std;
/*Generar un archivo con los socios menores que no se hayan inscripto en el 2020 con el siguiente
formato de registro:
DNI, nombre y apellido..*/
class SociosMenores{
private:
    int _DNI;
    char _nombre[30];
    char _apellido[30];
public:
    int grabarEnDisco(int DNI, const char *nombre, const char *apellido){
        FILE *p;
        p=fopen("Socios Menores.dat", "ab");
        _DNI=DNI;
        strcpy(_nombre,nombre);
        strcpy(_apellido,apellido);
        fwrite(this, sizeof(SociosMenores),1,p);
        fclose(p);
    }
};
void punto1();

main (){


	return 0;

}

void punto1(){
    Socio aux;
    SociosMenores reg;
    int pos=0;
    while(aux.leerDeDisco(pos++)){
        if(aux.getTipo==3){
            if(no2020(aux.getDNI())){
                reg.grabarEnDisco(aux.getDNI(),aux.getNombre(),aux.getApellid());
            }
        }
    }
}
bool no2020(int dni){
    Inscripcion aux;
    int pos=0;
    while (aux.leerDeDisco(pos++)){
        if (aux.getDNI==DNI && aux.getFecha_Inscripcion().getAnio()!=2020){
            return true;
        }
        else {return false;}
    }

}
