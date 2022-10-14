# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>

using namespace std;

class Equipo{
private:
    char nombreEquipo[30];
    char directorTecnico[30];
public:
    Equipo(){
        nombreEquipo="vacio";
        directorTecnico="vacio";
    }

};
/*Equipo::Equipo{
    nombreEquipo="vacio";
    directorTecnico="vacio";
}*/

main (){
	setlocale(LC_ALL, "");
	return 0;

}
