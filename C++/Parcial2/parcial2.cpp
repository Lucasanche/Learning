///Ejercicio: Parcial 2 de Programación II
///Autor:DEK
///Fecha:13/06/2022
///Comentario:

# include<iostream>
# include<cstdlib>
# include<cstring>

using namespace std;

void cargarCadena(char *pal, int tam){
    int i;
    fflush(stdin);
    for(i=0; i<tam; i++)
    {
        pal[i]=cin.get();
        if(pal[i]=='\n') break;
    }
    pal[i]='\0';
    fflush(stdin);
}


class Fecha{
private:
    int dia,mes, anio;
public:
    void Cargar(){
        cin>>dia;
        cin>>mes;
        cin>>anio;
    }
    void Mostrar(){
        cout<<dia<<"/";
        cout<<mes<<"/";
        cout<<anio<<endl;
    }
    int getDia(){return dia;}
    int getMes(){return mes;}
    int getAnio(){return anio;}

    void setDia(int d){dia=d;}
    void setMes(int m){mes=m;}
    void setAnio(int a){anio=a;}

};

class Obra{
private:
    char codigoObra[5];
    char direccion[30];
    int provincia;
    float superficie;
    int estadoEjecucion;
    bool activo;
public:
    void Cargar(){
        cargarCadena(codigoObra,4);
        cargarCadena(direccion,29);
        cin>>provincia;
        cin>>superficie;
        cin>>estadoEjecucion;
        activo=true;
    }

    void Mostrar(){
        cout<<codigoObra<<endl;
        cout<<direccion<<endl;
        cout<<provincia<<endl;
        cout<<superficie<<endl;
        cout<<estadoEjecucion<<endl;
    }

    const char* getCodigoObra(){return codigoObra;}
    const char* getDireccion(){return direccion;}
    int getProvincia(){return provincia;}
    int getEstadoEjecucion(){return estadoEjecucion;}
    float getSuperficie(){return superficie;}
    bool getActivo(){return activo;}

    void setCodigoObra(const char *co){strcpy(codigoObra, co);}
    void setDireccion(const char *d){strcpy(direccion,d);}
    void setProvincia(int p){provincia=p;}
    void setEstadoEjecucion(int e){estadoEjecucion=e;}
    void setSuperficie(float s){superficie=s;}
    void setActivo(bool a){activo=a;}

    int leerDeDisco(int pos){
        FILE *p;
        p=fopen("obras.dat", "rb");
        if(p==NULL) return -1;
        fseek(p, sizeof(Obra)*pos,0);
        int leyo=fread(this, sizeof *this,1, p);
        fclose(p);
        return leyo;
    }

    int grabarEnDisco(){
        FILE *p;
        p=fopen("obras.dat", "ab");
        if(p==NULL) return -1;
        int grabo=fwrite(this, sizeof *this,1, p);
        fclose(p);
        return grabo;
    }
};

class Material{
private:
    int codigoMaterial;
    char nombre[30];
    char marca[30];
    int tipo;
    float pu;
    bool activo;
public:
    void Cargar(){
        cin>>codigoMaterial;
        cargarCadena(nombre,29);
        cargarCadena(marca,29);
        cin>>tipo;
        cin>>pu;
        activo=true;
    }
    void Mostrar(){
        cout<<codigoMaterial<<endl;
        cout<<nombre<<endl;
        cout<<marca<<endl;
        cout<<tipo<<endl;
        cout<<pu<<endl;
    }
    int getCodigoMaterial(){return codigoMaterial;}
    int getTipo(){return tipo;}
    const char *getNombre(){return nombre;}
    const char *getMarca(){return marca;}
    float getPU(){return pu;}
    bool getActivo(){return activo;}

    void setCodigoMaterial(int cm){codigoMaterial=cm;}
    void setTipo(int t){tipo=t;}
    void setNombre(const char *m){strcpy(nombre,m);}
    void setMarca(const char *m){strcpy(marca,m);}
    void setPU(float p){pu=p;}
    void setActivo(bool a){activo=a;}

    int leerDeDisco(int pos){
        FILE *p;
        p=fopen("materiales.dat", "rb");
        if(p==NULL) return -1;
        fseek(p, sizeof *this*pos,0);
        int leyo=fread(this, sizeof *this,1, p);
        fclose(p);
        return leyo;
    }

    int grabarEnDisco(){
        FILE *p;
        p=fopen("materiales.dat", "ab");
        if(p==NULL) return -1;
        int grabo=fwrite(this, sizeof *this,1, p);
        fclose(p);
        return grabo;
    }
};

class Compra{
private:
    int numeroCompra, numeroProveedor, codigoMaterial;
    char codigoObra[5];
    int cantidad;
    float importe;
    Fecha fechaCompra;
    bool activo;
public:
    void Cargar(){
        cin>>numeroCompra;
        cin>>numeroProveedor;
        cin>>codigoMaterial;
        cargarCadena(codigoObra,4);
        cin>>cantidad;
        cin>>importe;
        fechaCompra.Cargar();
        activo=true;
    }

    void Mostrar(){
        cout<<numeroCompra<<endl;
        cout<<numeroProveedor<<endl;
        cout<<codigoMaterial<<endl;
        cout<<codigoObra<<endl;
        cout<<cantidad<<endl;
        cout<<importe<<endl;
        fechaCompra.Mostrar();
        cout<<endl;
    }
    int getNumeroCompra(){return numeroCompra;}
    int getNumeroproveedor(){return numeroProveedor;}
    int getCodigoMaterial(){return codigoMaterial;}
    int getCantidad(){return cantidad;}
    float getImporte(){return importe;}
    Fecha getFechaCompra(){return fechaCompra;}
    const char *getCodigoObra(){return codigoObra;}
    bool getActivo(){return activo;}

    void setNumeroCompra(int nc){numeroCompra=nc;}
    void setNumeroproveedor(int np){numeroProveedor=np;}
    void setCodigoMaterial(int cm){codigoMaterial=cm;}
    void setCantidad(int c){cantidad=c;}
    void setImporte(float i){importe=i;}
    void setFechaCompra(Fecha f){fechaCompra=f;}
    void setCodigoObra(const char *co){strcpy(codigoObra,co);}
    void setActivo(bool a){activo=a;}

    int leerDeDisco(int pos){
        FILE *p;
        p=fopen("compras.dat", "rb");
        if(p==NULL) return -1;
        fseek(p, sizeof *this*pos,0);
        int leyo=fread(this, sizeof *this,1, p);
        fclose(p);
        return leyo;
    }

    int grabarEnDisco(){
        FILE *p;
        p=fopen("compras.dat", "ab");
        if(p==NULL) return -1;
        int grabo=fwrite(this, sizeof *this,1, p);
        fclose(p);
        return grabo;
    }
    // Punto 4
    bool operator==(float aux) {
        if (importe == aux) {
            return true;
        }
        else {
            return false;
        }
    }
};

class Proveedor{
private:
    int numeroProveedor;
    char nombre[30];
    char telefono[30];
    char direccion[30];
    int provincia;
    bool activo;
public:
    void Cargar(){
        cin>>numeroProveedor;
        cargarCadena(nombre,29);
        cargarCadena(telefono,29);
        cargarCadena(direccion,29);
        cin>>provincia;
        activo=true;
    }
    void Mostrar(){
        cout<<numeroProveedor<<endl;
        cout<<nombre<<endl;
        cout<<telefono<<endl;
        cout<<direccion<<endl;
        cout<<provincia<<endl;
    }

    int getNumeroProveedor(){return numeroProveedor;}
    int getProvincia(){return provincia;}
    const char *getNombre(){return nombre;}
    const char *getTelefono(){return telefono;}
    const char *getDireccion(){return direccion;}
    bool getActivo(){return activo;}

    void setNumeroProveedor(int np){numeroProveedor=np;}
    void setProvincia(int np){provincia=np;}
    void setNombre(const char *n){strcpy(nombre,n);}
    void setTelefono(const char *n){strcpy(telefono,n);}
    void setDireccion(const char *n){strcpy(direccion,n);}
    void setActivo(bool a){activo=a;}

    int leerDeDisco(int pos){
        FILE *p;
        p=fopen("proveedores.dat", "rb");
        if(p==NULL) return -1;
        fseek(p, sizeof *this*pos,0);
        int leyo=fread(this, sizeof *this,1, p);
        fclose(p);
        return leyo;
    }

    int grabarEnDisco(){
        FILE *p;
        p=fopen("proveedores.dat", "ab");
        if(p==NULL) return -1;
        int grabo=fwrite(this, sizeof *this,1, p);
        fclose(p);
        return grabo;
    }
};

class regObras {
private:
    char _codigoObra[5];
    char _Direccion[30];
    int _cantCompras;
public:
    void setCodigoObra(const char* codigoObra) { strcpy(_codigoObra, codigoObra); }
    void setDireccion(const char* Direccion) { strcpy(_Direccion, Direccion); }
    void setCantCompras(int cantCompras) { _cantCompras = cantCompras; }
    void Cargar(const char* codigoObra, const char* Direccion, int cantCompras) {
        strcpy(_codigoObra, codigoObra);
        strcpy(_Direccion, Direccion);
        _cantCompras = cantCompras;
    }
    void Mostrar() {
        cout << _codigoObra << "   " << _Direccion << "   " << _cantCompras << endl;
    }
    int leerDeDisco(int pos) {
        FILE* p;
        p = fopen("regObras.dat", "rb");
        if (p == NULL) return -1;
        fseek(p, sizeof * this * pos, 0);
        int leyo = fread(this, sizeof * this, 1, p);
        fclose(p);
        return leyo;
    }
    int grabarEnDisco() {
        FILE* p;
        p = fopen("regObras.dat", "ab");
        if (p == NULL) return -1;
        int grabo = fwrite(this, sizeof * this, 1, p);
        fclose(p);
        return grabo;
    }
    void operator+=(int valor) {
        _cantCompras = valor;
    }
};

int contadorCompras(Compra& comp, Obra &obra) {
    int posComp = 0;
    int contCompras = 0;
    while (comp.leerDeDisco(posComp++) == 1) {
        if (comp.getCodigoObra() == obra.getCodigoObra()) { contCompras++; }
    }
    cout << "cantidad de compras " << contCompras << endl;
    return contCompras;
}

void Punto1() {
    Obra obra;
    Compra comp;
    regObras reg;
    int posObra = 0;
    while (obra.leerDeDisco(posObra++)==1) {
        reg.setCodigoObra(obra.getCodigoObra());
        reg.setDireccion(obra.getDireccion());
        reg.setCantCompras(contadorCompras(comp, obra));
        reg.grabarEnDisco();
    }
    posObra = 0;
    cout << "Código de obra   Dirección    Cantidad" << endl;
    while (reg.leerDeDisco(posObra++) == 1) {
        reg.Mostrar();
    }
}
void Punto2() {
    int i, pos = 0;
    int cantProvincias = 24;
    int* contProveedores = new int[cantProvincias];
    Proveedor proveedor;

    for (i = 0; i < cantProvincias; i++) {
        contProveedores[i] = 0;
        while (proveedor.leerDeDisco(pos++) == 1) {
            if (proveedor.getProvincia() == (i + 1)) {
                contProveedores[i]++;
            }
        }
        if (contProveedores[i] != 0) {
            cout << "La provincia " << i + 1 << " tiene " << contProveedores[i] << " proveedor/es" << endl;
        }
        else {
            cout << "La provincia " << i + 1 << " no tiene proveedores" << endl;
        }
    }
    delete[] contProveedores;
}

int contarRegistrosCompras() {
    int cantidad = 0;
    int pos = 0;
    Compra aux;
    while (aux.leerDeDisco(pos++) == 1) {
        cantidad = pos + 1;
    }
    return cantidad;
}

void Punto3() {
    int cantidadCompras = contarRegistrosCompras();
    Compra* vCompras = new Compra[cantidadCompras];
    Compra aux;
    int i, valor;
    for (i = 0; i < cantidadCompras; i++) {
        aux.leerDeDisco(i);
        vCompras[i] = aux;
    }
    cout << "Ingrese un valor " << endl;
    cin >> valor;
    for (i = 0; i < cantidadCompras; i++) {
        if (vCompras[i].getImporte() < valor) {
            cout << "La compra " << vCompras[i].getNumeroCompra() << " tiene un importe menor al ingresado" << endl;
        }
    }
    delete[] vCompras;
}


int main() {
    cout << endl;
   // Punto2();
    Punto3();
    
    /*Proveedor aux;
    int pos = 0;
    while (aux.leerDeDisco(pos++) == 1) {
        cout << aux.getProvincia() << endl;
    }*/
	system("pause");
	return 0;
}
