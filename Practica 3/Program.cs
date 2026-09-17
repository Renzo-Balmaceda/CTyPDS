/*
 * Crear un ReproductorMp3, un ReproductorAvanzadoExterno y un
AdaptadorReproductorAvanzado utilizando el reproductor externo.
Utilizar el método ReproducirArchivo para reproducir: un archivo .mp3, un archivo .avi y un
archivo .mp4
El método ReproducirArchivo no debe conocer las clases concretas. Solamente debe
trabajar con IReproductor.
 * */

using Practica_3;
using Practica_3.Adapter;
using Practica_3.Command;
using Practica_3.Proxy;
/*
 ///======Adapter=======
ReproductorMP3 reproductorMP3 = new ReproductorMP3();
ReproductorAvanzadoExterno rAvanzadoExterno= new ReproductorAvanzadoExterno();
AdaptadorReproductorAvanzado adaptador = new AdaptadorReproductorAvanzado(rAvanzadoExterno);
Utilidades.ReproducirArchivo(reproductorMP3, "Despacito.mp3");
Utilidades.ReproducirArchivo(adaptador, "Parasite.avi");
Utilidades.ReproducirArchivo(adaptador, "Stuck in the Sound - Let's Go[Video Oficial].mp4");

/// ======Proxy======
DocumentoProxy dProxy= new DocumentoProxy();
Console.WriteLine(dProxy.Leer("Pedro"));
Console.WriteLine(dProxy.Leer("admin"));
Console.WriteLine(dProxy.Leer("admin"));
*/

// ======Command======
Luz luz = new Luz();
ComandoEncenderLuz encenderLuz = new ComandoEncenderLuz(luz);
ComandoApagarLuz apagarLuz = new ComandoApagarLuz(luz);
ControlRemoto Control= new ControlRemoto();
Control.Ejecutar(encenderLuz);
Control.Ejecutar(apagarLuz);
Control.Ejecutar(encenderLuz);
Control.Ejecutar(apagarLuz);
Control.DeshacerUltimo();