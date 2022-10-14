# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>

using namespace std;

class Cadena {
private:
    const char *cadena[25];
public:
    void cargaCadena(const char *c,int tam){
        for (int x=0; x<tam ;x++){
            cadena[x]=c;
        }
    }
};

main (){
	setlocale(LC_ALL, "");
    const char *cadena="hola";
    cout << cadena;
	return 0;

}
