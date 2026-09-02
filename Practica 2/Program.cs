
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

//EJERCICIO 14
Pila pila = new Pila();
Cola cola = new Cola();
Utilidades.LLenarFactory(pila, 0);
Utilidades.LLenarFactory(cola , 1);
Utilidades.InformarFactory(pila, 0);
Utilidades.InformarFactory(cola, 1);


//EJERCICIO 18
Canal canal = (Canal)FabricaDeComparables.CrearPorTeclado(2);
Random rand = new Random();
string[] nombres = { "Juan",
                "Pedro",
                "Ana",
                "Lucía",
                "Sofía",
                "Carlos" };
for (int i = 0; i < 20; i++)
{
    string nombre = nombres[rand.Next(nombres.Length)];
    int id = rand.Next(100000, 999999);
    int m = rand.Next(0,1000);
    int h = rand.Next(0,1000);
    Suscriptor suscriptor_observador = new Suscriptor(nombre, id, m, h);
    canal.AgregarObservador(suscriptor_observador);
}
Utilidades.TemporadaDeContenido(canal);


//EJERCICIO 21

Mostrable s= new Suscriptor("Renzo", 141241, 12, 223);
s = new DecoradorMesesAntiguedad(s);
s = new DecoradorRango(s);
s = new DecoradorEstadoCuenta(s);
s = new DecoradorRecuadro(s);
Console.WriteLine(s.MostrarInfo());
*/

//EJERCICIO 22

Canal c = new Canal("CTyDPS");
for (int i = 0; i < 10; i++)
{
    Suscriptor s = (Suscriptor)FabricaDeComparables.CrearAleatorio(1);
    c.AgregarObservador(s);
}
Utilidades.TemporadaDeContenido(c);
foreach (Suscriptor suscriptor in c.GetSuscriptores())
{
    Mostrable s = suscriptor;
    s = new DecoradorMesesAntiguedad(s);
    s = new DecoradorRango(s);
    s = new DecoradorEstadoCuenta(s);
    s = new DecoradorRecuadro(s);
    Console.WriteLine(s.MostrarInfo());
}

