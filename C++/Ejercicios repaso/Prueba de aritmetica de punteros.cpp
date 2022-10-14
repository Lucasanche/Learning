# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <wchar.h>
# include <windows.h>
# include <ctime>

using namespace std;

void Cargar(int (*)[5], int, int);
void Mostrar(int (*)[5],int, int);

main (){
    setlocale(LC_ALL, "");
    int vect[5][5]={};
    int a, b;
    Mostrar(vect, 5, 5);
    cout << endl << endl;
    Cargar(vect, 5, 5);
    cout << endl << endl;
    Mostrar(vect, 5, 5);
    cout << endl << endl;
    return 0;
}


void Cargar(int (*vec)[5], int fila, int col){
    int i, j;
    int k=0;
    for (i=0;i<fila;i++){
        for (j=0;j<col;j++){
            *(*(vec+i)+j)=k++;
        }
    }
}

void Mostrar(int (*vec)[5], int fila, int col){
    int i, j;
    int k=0;
    for (i=0;i<fila;i++){
        cout << endl;
        for (j=0;j<col;j++){
            cout << *(*(vec+i)+j) << "\t";
        }
    }
}
