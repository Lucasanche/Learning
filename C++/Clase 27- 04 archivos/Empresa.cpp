# include<iostream>
# include<cstdlib>

using namespace std;

class Empresa{
private:
    int numeroEmpresa;
    char nombre[30];
    int cantidadEmpleados, categoria, numeroMunicipio;
    bool estado;
public:
    /// a)Calcular e informar la cantidad de empresas de cada municipio.
    /// b)Informar los nombres de las empresas con más de 200 empleados.
    /// c)Calcular e informar la categoría de empresa con más empleados
    //TODO sets()
    //TODO gets()
    int getCantidadEmpleados(){return cantidadEmpleados;}
    const char *getNombreEmpresa(){return nombre;}
    int getNumeroMunicipio(){return numeroMunicipio;}
    int getCategoria(){return categoria;}
    void Cargar();
    void Mostrar();
    int grabarRegistro();
    int leerRegistro(int);

};
void mostrarRegistros();
void puntoA();
void puntoB();
void puntoC();
void mostrarPuntoA(int *v, int tam);


int main (){
	setlocale(LC_ALL, "");
	int opc;
	int pos;
	Empresa aux;
    do {
        system("cls");
        cout << "------MENU PRINCIPAL------" << endl;
        cout << "1. Punto A" << endl;
        cout << "2. Punto B" << endl;
        cout << "3. Punto C"<< endl;
        cout << "4. Grabar Registro" << endl;
        cout << "5. Mostrar Registro" << endl;
        cout << "0. Salir " << endl;
        cin >> opc;

        switch (opc)
        {
        case 1:
            puntoA();
            system("pause");
            break;
        case 2:
            puntoB();
            break;
        case 3:
            puntoC();
            break;
        case 4:
            aux.Cargar();
            aux.grabarRegistro();
            break;
        case 5:
            mostrarRegistros();
            system("pause");
            break;
        case 0:
            cout << "Fin del programa";
            return 0;
        default:
            break;
        }
    }
    while(opc!=0);
}

void Empresa::Cargar(){
    cout<< "Ingrese el número de la empresa: ";
    cin >> numeroEmpresa;
    cout<< "Ingrese el nombre de la empresa: ";
    cin >> nombre;
    cout<< "Ingrese la cantidad de empleados: ";
    cin >> cantidadEmpleados;
    cout<< "Ingrese la categoria: ";
    cin >> categoria;
    cout<< "Ingrese el numero de municipio: ";
    cin >> numeroMunicipio;
    estado=true;
}

void Empresa::Mostrar(){
    cout<<"NUMERO DE EMPRESA: ";
    cout<<numeroEmpresa<<endl;
    cout<<"NOMBRE DE EMPRESA: ";
    cout<<nombre<<endl;
    cout<<"CANTIDAD DE EMPLEADOS: ";
    cout<<cantidadEmpleados<<endl;
    cout<<"CATEGORIA: ";
    cout<<categoria<<endl;
    cout<<"NUMERO DE MUNICIPIO: ";
    cout<<numeroMunicipio<<endl<<endl;
}

int Empresa::grabarRegistro(){
    FILE *p;
    p=fopen("empresas.dat", "ab");
    if (p==NULL) return -1;
    bool escribio;
    escribio=fwrite(this, sizeof(Empresa),1,p);
    fclose(p);
    return escribio;
}

int Empresa::leerRegistro(int pos){
    FILE *p;
    p=fopen("empresas.dat", "rb");
    if (p==NULL) return -1;
    fseek(p, sizeof(Empresa)*pos,1);
    bool leyo;
    leyo=fread(this, sizeof(Empresa), 1, p);
    fclose(p);
    return leyo;
}

void puntoA(){
    int vMunicipio[135]={}, pos=0;
    Empresa aux;
    while(aux.leerRegistro(pos)==1){
        vMunicipio[aux.getNumeroMunicipio()-1]++;
        pos++;
    }
    mostrarPuntoA(vMunicipio, 135);
}

void puntoB(){
    Empresa aux;
    int pos=0;
    cout << "Empresas con más de 200 empleados: " << endl;
    while(aux.leerRegistro(pos)==1){
        if (aux.getCantidadEmpleados()>200){

            cout << "-" << aux.getNombreEmpresa() << "-" << endl;
        }
    pos++;
    }
    system("pause");
}

void puntoC(){
    int categoria[80]={}, pos=1, empleadosMaximo=0, categoriaMaxima;
    Empresa aux;
    while(aux.leerRegistro(pos)==1){
        categoria[aux.getCategoria()-1]+=aux.getCantidadEmpleados();
        if (categoria[aux.getCategoria()-1]>empleadosMaximo){
            empleadosMaximo=categoria[aux.getCategoria()-1];
            categoriaMaxima=aux.getCategoria();
        }
        pos++;
    }
    cout << "La categoria con más empleados es la: " << categoriaMaxima;
    system("pause");
}

void mostrarPuntoA(int *v,int tam){
    for (int i=0;i<tam;i++){
        if (v[i]>0){
            cout << "El municipio " << i+1 << "tiene " << v[i] << " empresas." << endl << endl;
        }
    }
    cout << endl;
}

void mostrarRegistros(){
    Empresa reg;
    int pos=0;
    while(reg.leerRegistro(pos)){
        reg.Mostrar();
        pos++;
    }
}
