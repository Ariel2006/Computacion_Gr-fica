// ConsoleApplication1.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;


class Promedio {
	public:
	int nota1, nota2, nota3;
	float promedio;
	void setNota1(int);
	void setNota2(int);
	void setNota3(int);
	int getNota1();
	int getNota2();
	int getNota3();
	float getPromedio();
	void imprimir();
};


	void Promedio::setNota1(int nota1) {
	nota1 = 10;
}

void Promedio::setNota2(int nota2) {
	nota2 = 10;
}

void Promedio::setNota3(int nota3) {
	nota3 = 10;
}

int Promedio::getNota1() {
	return nota1;
}

int Promedio::getNota2() {
	return nota2;
}

int Promedio::getNota3() {
	return nota3;
}

float Promedio::getPromedio() {
	return promedio;
}

void Promedio::imprimir() {
	cout << "Nota 1: " << nota1 << endl;
	cout << "Nota 2: " << nota2 << endl;
	cout << "Nota 3: " << nota3 << endl;
	cout << "Promedio: " << promedio << endl;
}

int main()
{
	Promedio promedio;
	promedio.setNota1(1);
	promedio.setNota2(10);
	promedio.setNota3(25);
	promedio.imprimir();
	return 0;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
