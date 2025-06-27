// ASUMA.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <sstream>
#include <algorithm>
using namespace std;

class Suma {
	public:
	int suma(int a, int b) {
		return a + b;
	}
};

class Division {
	public:
	float division(float a, float b) {
		return a / b;
	}
};

class  factorial {
	public:
	int fact(float a) {
		int fact = 1;
		for (int i = 1; i <= a; i++) {
			fact = fact * i;
		}
		return fact;
	}
};

class euler {
	public:
	float euler1(float a) {
		float euler = 1;
		for (int i = 1; i <= a; i++) {
			euler = euler + (1 / factorial().fact(i));
		}
		return euler;
	}
};

class marquesina {
	public:
	void marquesina1(int a) {
		for (int i = 0; i < a; i++) {
			cout << "*";
		}
		cout << endl;
	}
};

class gotoxy {
	public:
	void gotoxy1(int x, int y) {
		COORD coord;
		coord.X = x;
		coord.Y = y;
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
	}
};

int main()
{
	Suma s;
	Division d;
	int a, b;
	cout << "Ingrese el primer numero: ";
	cin >> a;
	cout << "Ingrese el segundo numero: ";
	cin >> b;
	cout << "La suma de los numeros es: " << s.suma(a, b) << endl;
	cout << "La division de los numeros es: " << d.division(a, b) << endl;
	factorial f;
	cout << "El factorial del numero es: " << f.fact(a) << endl;
	euler e;
	cout << "El valor de euler es: " << e.euler1(a) << endl;
	marquesina m;
	cout << "La marquesina es: " << endl;
	m.marquesina1(a);
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
