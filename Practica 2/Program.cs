
using Practica_2;

//EJERCICIO 2
/*
Cola cola = new Cola();
Utilidades.llenarSuscriptores(cola);
Utilidades.Informar(cola);

EJERCICIO 7
Pila pila = new Pila();
Cola cola = new Cola();
Playlist playlist = new Playlist();
Utilidades.llenarSuscriptores(pila);
Utilidades.llenarSuscriptores(cola);
Utilidades.llenarSuscriptores(playlist);
Utilidades.ImprimirElementos(pila);
Utilidades.ImprimirElementos(cola);
Utilidades.ImprimirElementos(playlist);
*/

// EJERCICIO 9
Pila pila = new Pila();
Utilidades.llenarSuscriptores(pila);
Utilidades.CambiarEstrategia(pila,new EstrategiaPorNombre() );
Utilidades.Informar(pila);
Utilidades.CambiarEstrategia(pila, new EstrategiaPorMesesDeSuscripcion());
Utilidades.Informar(pila);
Utilidades.CambiarEstrategia(pila, new EstrategiaPorHorasVistas());
Utilidades.Informar(pila);
Utilidades.CambiarEstrategia(pila, new EstrategiaPorID());
Utilidades.Informar(pila);