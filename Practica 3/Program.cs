using Practica_3.Adapter;
using Practica_3.Command;
using Practica_3.Composite;
using Practica_3.Proxy;
using Practica_3.Singleton;
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


// ======Composite======
Carpeta CarpetaRaiz = new Carpeta("PC");
Carpeta Subcarpeta1 = new Carpeta("Usuario1");
Carpeta SubCarpeta2 = new Carpeta("Usuario2");
Archivo archivo1 = new Archivo("readme.txt", 213);
Archivo archivo2 = new Archivo("glosario-libro.txt", 126);
Archivo archivo3 = new Archivo("tabla.xlc", 328);
Archivo archivo4 = new Archivo("leccion.mp3", 753);
CarpetaRaiz.AgregarElementos(Subcarpeta1);
CarpetaRaiz.AgregarElementos(SubCarpeta2);
Subcarpeta1.AgregarElementos(archivo1);
Subcarpeta1.AgregarElementos(archivo2);
SubCarpeta2.AgregarElementos(archivo3);
SubCarpeta2.AgregarElementos(archivo4);
CarpetaRaiz.Mostrar(4);


// ======Template Method======
PreparadorDeCafé p1= new PreparadorDeCafé();
PreparadorDeTe p2= new PreparadorDeTe();
Console.WriteLine("Preparador de Café: ");
p1.PrepararBebida();
Console.WriteLine("");
Console.WriteLine("Preparador de Té: ");
p2.PrepararBebida();


//======Chain of Responsability======
Director aprobador= new Director();
Gerente aprobador2 = new Gerente(aprobador);
Supervisor aprobador3= new Supervisor(aprobador2);
SolicitudDeGasto s1 = new SolicitudDeGasto(343, "Entrada para la despedida de Messi");
SolicitudDeGasto s2 = new SolicitudDeGasto(1232, "Compra de una moto");
SolicitudDeGasto s3 = new SolicitudDeGasto(1500000000, "Compra del Burj Khalifa");
aprobador3.Aprobar(s1);
aprobador3.Aprobar(s2);
aprobador3.Aprobar(s3);
//Caden Incompleta
Gerente aprobador11 = new Gerente(null);
Supervisor aprobador12= new Supervisor(aprobador11);
SolicitudDeGasto s4 = new SolicitudDeGasto(110000000, "Compra de la Casa Blanca");
aprobador12.Aprobar(s4);
*/


//Singleton
ConfiguracionDelSistema Config =ConfiguracionDelSistema.ObtenerInstancia();
Config.EstablecerValor("River Plate", 91218);
ConfiguracionDelSistema Config2 = ConfiguracionDelSistema.ObtenerInstancia();
Console.WriteLine(Config2.ObtenerValor("River Plate"));

