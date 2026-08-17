using Practica_1;
//EJERCICIO 7
Pila pila = new Pila();
Cola cola = new Cola();
//EJERCICIO 9
Catalogo c = new Catalogo(pila, cola);
/*Utilidades.LLenar(pila);
Utilidades.LLenar(cola);
Utilidades.Informar(pila);
Utilidades.Informar(cola);
*/
Utilidades.llenarSuscriptores(pila);
Utilidades.llenarSuscriptores(cola);
Utilidades.Informar(c);