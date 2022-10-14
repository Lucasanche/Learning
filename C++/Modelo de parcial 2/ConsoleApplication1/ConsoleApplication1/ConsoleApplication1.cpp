#include <iostream>

class Ciudades
{
private:
	int codCiudad;
	char* nombre;
	int codProvincia;
public:
	bool operator==(Punto1&);
	bool leerDeDisco(int pos) {
		FILE* p;
		p = fopen("Ciudades.dat", "rb");
		if (p == NULL) {
			return false;
		}
		bool leyo =	fread(this, sizeof(this), 1, p);
		return leyo;
	}
	int getCodigoCiudad() { return codCiudad; }
	

};

class Mediciones
{
private:
	int codCiudad;
	int visibilidad;
	int temperatura;
	int Fecha;
public:
	void LeerDeDisco() {

	}
	int getVisibilidad() { return visibilidad; }
	void GrabarEnDisco() {
		FILE* p;
		p = fopen("Mediciones.dat", "ab");

	}
	bool operator==(int cod) {
		if (codCiudad == cod) {
			return true;
		}
	}
};


class Punto1
{
private:
	int _codigoCiudad;
	char _nombre[30];
	float _promedio;
public:
	void setCodigoCiudad(int codigoCiudad) { _codigoCiudad = codigoCiudad; }
	void setPromedio(int promedio) { _promedio = promedio; }
	void setNombre(const char* nombre) { strcpy(_nombre, nombre); }
	bool grabarEnDisco(int pos){
		FILE* p = fopen("punto1.dat", "ab");
		if (p == NULL) { return false; }
		bool escribio = fwrite(this, sizeof(Punto1), 1, p);
		fclose(p);
		return escribio;
	}
};

float calcularPromedio(int cod) {
	Mediciones reg;
	int pos = 0;
	int cantMediciones = 0;
	int acuMediciones = 0;
	float promedio;
	while (reg.LeerDeDisco(pos) == 1) {
		if (reg == cod) {
			cantMediciones++;
			acuMediciones += reg.getVisibilidad();
		}
	}
	promedio = acuMediciones / cantMediciones;
	return promedio;
}


int main() {
	Ciudades reg;
	Punto1 aux;
	int pos = 0;
	while (reg.leerDeDisco(pos) == 1) {
		aux.setCodigoCiudad(reg.getCodigoCiudad());
		//etc para todos los datos
		aux.setPromedio(calcularPromedio(reg.getCodigoCiudad()));
		aux.grabarEnDisco(pos);
	}
}

