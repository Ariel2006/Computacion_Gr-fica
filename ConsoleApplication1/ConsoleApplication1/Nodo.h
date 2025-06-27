#pragma once
#include <iostream> 
#include <stdio.h>
using namespace std;
class Nodo
{
private:

public:
	int dato;
	Nodo* izquierda;
	Nodo* derecha;
	void setDato(int);
	void setIzquierda(Nodo*);
	void setDerecha(Nodo*);
	int getDato();
	Nodo*& getIzquierda();
	Nodo*& getDerecha();
	/*devuelve la informacion del nodo*/
};
void Nodo::setDato(int _dato) {
	dato = _dato;
}
void Nodo::setIzquierda(Nodo* _izquierda) {
	izquierda = _izquierda;
}
void Nodo::setDerecha(Nodo* _derecha) {
	derecha = _derecha;
}
int Nodo::getDato() {
	return dato;
}
int maxProfundidad(Nodo* Nodo)
{
	if (Nodo == NULL)
		return -1;
	else
	{
		/* compute the depth of each subarbol */
		int lProfundidad = maxProfundidad(Nodo->izquierda);
		int rProfundidad = maxProfundidad(Nodo->derecha);

		/* use the larger one */
		if (lProfundidad > rProfundidad)
			return(lProfundidad + 1);
		else return(rProfundidad + 1);
	}
}

int arbol_altura(Nodo* root) {
	// Get the altura of the arbol
	if (!root)
		return 0;
	else {
		// Find the altura of both subarbols
		// and use the larger one
		int izquierda_altura = arbol_altura(root->izquierda);
		int derecha_altura = arbol_altura(root->derecha);
		if (izquierda_altura >= derecha_altura)
			return izquierda_altura + 1;
		else
			return derecha_altura + 1;
	}
}

int getAnchura(Nodo* root, int nivel)
{

	if (root == NULL)
		return 0;

	if (nivel == 1)
		return 1;

	else if (nivel > 1)
		return getAnchura(root->izquierda, nivel - 1)
		+ getAnchura(root->derecha, nivel - 1);
}
Nodo*& Nodo::getIzquierda() {
	return izquierda;
}
Nodo*& Nodo::getDerecha() {
	return derecha;
}