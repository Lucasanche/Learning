///Ejercicio:
///Autor:DEK
///Fecha:
///Comentario:

# include<iostream>
# include<cstdlib>
# include<cstring>

using namespace std;

///CONSTRUCTOR/ES: METODO QUE TIENE EL MISMO NOMBRE QUE LA CLASE
            ///    NO DEVUELVE NADA
            ///    SE EJECUTA DE MANERA AUTOMATICA CUANDO EL OBJETO NACE
            ///    EN GENERAL SE LOS UTILIZA PARA DARLE VALORES INICIALES A LAS PROP.
///DESTRUCTOR:  METODO QUE TIENE EL MISMO NOMBRE QUE LA CLASE CON EL CARACTER ~
            /// NO DEVUELVE NADA NI ACEPTA PARAMETROS
            /// SE EJECUTA DE MANERA AUTOMATICA AL FINALIZAR EL OBJETO


class Alumno{
    private:///no es accesible desde fuera de la clase
        int legajo, edad;///propiedades-> variables de la clase
        char nombre[25], apellido[30];
    public:///es accesible desde fuera de la clase
        Alumno(int leg=0, int e=0, const char *n="vacio", const char *ape="vacio"){
            legajo=leg;
            edad=e;
            strcpy(nombre,n);
            strcpy(apellido,ape);
        }
        /*Alumno(){
            legajo=0;
            edad=0;
            strcpy(nombre, "vacio");
            strcpy(apellido, "vacio");
        }*/

        void Cargar();
        void Mostrar();
        ///sets()->permite asignar valor a cada propiedad
        void setLegajo(int l){legajo=l;}
        void setEdad(int e){edad=e;}


        void setNombre(const char n[]){strcpy(nombre,n);}



        void setApellido(const char *n){strcpy(apellido,n);}

        ///gets()->permite que el mundo externo sepa el valor de una propiedad
        int getLegajo(){return legajo;}
        int getEdad(){return edad;}
        const char* getNombre(){return nombre;}
        const char *getApellido(){return apellido;}
        ~Alumno(){cout<<"SE MURIO EL OBJETO :-("<<endl;}

};



void Alumno::Mostrar(){
            cout<<"LEGAJO: ";
            cout<<legajo<<endl;
            cout<<"EDAD: ";
            cout<<edad<<endl;
            cout<<"NOMBRE: ";
            cout<<nombre<<endl;
            cout<<"APELLIDO: ";
            cout<<apellido<<endl;
        }

void Alumno::Cargar(){
            cout<<"LEGAJO: ";
            cin>>legajo;
            cout<<"EDAD: ";
            cin>>edad;
            cout<<"NOMBRE: ";
            cin>>nombre;
            cout<<"APELLIDO: ";
            cin>>apellido;
        }


int main(){
    Alumno obj(1234, 21, "OLGA", "PEREZ"), reg(5555, 19), obj2;

    obj.Mostrar();
    cout<<endl;
    reg.Mostrar();
    cout<<endl;
    obj2.Mostrar();
    cout<<endl;
	system("pause");
	return 0;
}
