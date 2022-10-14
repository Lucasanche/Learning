///Ejercicio:
///Autor:DEK
///Fecha:
///Comentario:

# include<iostream>
# include<cstdlib>

using namespace std;


///COMPOSICION: ES UN MECANISMO QUE PERMITE EL USO DE UN OBJETO DE UNA CLASE, COMO PROPIEDAD DE OTRA CLASE

class Fecha{
private:
    int dia, mes, anio;
public:
    Fecha(int d=0, int m=0, int a=0){
        dia=d;
        mes=m;
        anio=a;
    }
    ///gets()
    int getDia(){return dia;}
    int getMes(){return mes;}
    int getAnio(){return anio;}
    ///sets()
    void setDia(int d){if(d>0 && d<=31) dia=d;}
    void setMes(int m){mes=m;}
    void setAnio(int a){anio=a;}

    void Cargar(){
        int d, m, a;
        cout<<"INGRESE EL DIA: ";
        cin>>d;
        cout<<"INGRESE EL MES: ";
        cin>>m;
        cout<<"INGRESE EL ANIO: ";
        cin>>a;
        setDia(d);
        setMes(m);
        setAnio(a);
    }
    void Mostrar();
};

void Fecha::Mostrar(){
        cout<<dia<<"/"<<mes<<"/"<<anio<<endl;
    }

///clase Venta tiene Fecha de venta
class Venta{
private:
    int numeroVenta, codigoArticulo, cantidad;
    float importe;
    ///int dia, mes, anio; en lugar de usar prop sueltas usa un objeto Fecha
    Fecha diaVenta;
public:
    int getNumeroVenta(){return numeroVenta;}
    void setNumeroVenta(int nv){numeroVenta=nv;}

    Fecha getDiaVenta(){return diaVenta;}
    void setDiaVenta(Fecha dv){diaVenta=dv;}

    void setDia(int d){diaVenta.setDia(d);}

    void Cargar();
    void Mostrar();

};

void Venta::Cargar(){
    cout<<"NUMERO: ";
    cin>>numeroVenta;
    cout<<"ARTICULO: ";
    cin>>codigoArticulo;
    cout<<"CANTIDAD: ";
    cin>>cantidad;
    cout<<"IMPORTE: ";
    cin>>importe;

    diaVenta.Cargar();

}

void Venta::Mostrar(){
    cout<<"NUMERO: ";
    cout<<numeroVenta<<endl;
    cout<<"ARTICULO: ";
    cout<<codigoArticulo<<endl;
    cout<<"CANTIDAD: ";
    cout<<cantidad<<endl;
    cout<<"IMPORTE: ";
    cout<<importe<<endl;

    diaVenta.Mostrar();

}



int main(){
    Venta reg;
    //reg.Cargar();
    cout<<reg.getDiaVenta().getAnio();
	cout<<endl;
	system("pause");
	return 0;
}
