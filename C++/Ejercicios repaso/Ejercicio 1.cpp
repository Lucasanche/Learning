# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
#include <windows.h>
#include <ctime>

using namespace std;
int devolver_minimo(int, int*);
main (){
    int vec_num[5];
    int tam_vec=5;
    int maximo;
    for (int i=0;i<tam_vec;i++){
        cout << "ingrese un numero: " << endl;
        cin >> vec_num[i];
    }
    cout << endl << "El valor maximo es: " << devolver_maximo(tam_vec, vec_num);


return 0;

}

int devolver_maximo(int cantidad, int *numeros){
    int maximo=8;
    int i;
    for (i=0; i<cantidad; i++){
        if (i==0){
            maximo=numeros[0];
        }
        else if (numeros[i]>maximo){
                maximo=numeros[i];
        }
    }
    return minimo;
}
