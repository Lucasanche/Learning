///Ejercicio:
///Autor:DEK
///Fecha:
///Comentario:

# include<iostream>
# include<cstdlib>

using namespace std;


///Clase: molde donde se definen las propiedades y el comportamiento de los objetos de esa clase.
///Es un tipo de dato
///Las variables de una clase se llaman: OBJETO
///CLASE FECHA:
///Propiedades: dia, mes y año.
///private, public:especificadores de acceso (protected)

///Puntero this: es un puntero que contiene la dirección del objeto que llama al método. Sólo existe dentro de la clase
///Suele decirse que es un puntero oculto

class Fecha{
private:///es accesible dentro de la clase
    int dia, mes, anio;///propiedades
public:///es accesible dentro y fuera de la clase
    Fecha(int d=0, int m=0, int a=0){
        this->dia=d;
        mes=m;
        this->anio=a;
    }
    ///gets() funciones de la clase que permiten hacer conocer al exterior de la clase el valor de cada prop.
    int getDia(){return dia;}
    int getMes(){return mes;}
    int getAnio(){return anio;}
    ///sets() funciones que permiten modificar los valores de cada una de las propiedades
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
        this->setDia(d);
        setMes(m);
        setAnio(a);
    }
    void Mostrar();
    void Mostrar_this(){
        cout<<this<<endl;
    }

};

void Fecha::Mostrar(){
        char meses[3][11]={"ENERO", "FEBRERO","MARZO"};
        /*cout<<"DIA: "<<getDia()<<endl;
        cout<<"MES: "<<getMes()<<endl;
        cout<<"ANIO: "<<getAnio()<<endl;
        cout<<endl<<endl;*/
        cout<<dia<<"/"<<mes<<"/"<<anio<<endl;
        /*cout<<endl<<endl;
        cout<<dia<<"/"<<meses[mes-1]<<"/"<<anio<<endl;*/
    }


int main(){
    Fecha obj, date(1,1,2022);

/*
    cout<<&obj<<endl;///muestro la dirección de obj
    obj.Mostrar_this();
    cout<<endl;
    cout<<&date<<endl;///muestro la dirección de obj
    date.Mostrar_this();

*/
    obj.Mostrar();
	cout<<endl;
	system("pause");
	return 0;
}
