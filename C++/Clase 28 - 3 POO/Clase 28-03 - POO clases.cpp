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
    Equipo();
    const char *getNombreEquipo(){return nombreEquipo;}
};
Equipo::Equipo(){
    strcpy(nombreEquipo,"vacio");
    strcpy(directorTecnico,"vacio");
}

main (){
	setlocale(LC_ALL, "");
	Equipo reg;
    cout << reg.getNombreEquipo();
	return 0;

}





