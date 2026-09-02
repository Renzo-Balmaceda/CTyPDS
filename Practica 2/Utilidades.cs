using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public static class Utilidades
    {
        public static void Informar(Coleccionable c)
        {
            Console.WriteLine(c.Cuantos());
            Console.WriteLine(c.Minimo());
            Console.WriteLine(c.Maximo());
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Meses de suscripcion: ");
            int meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de horas vistas:");
            int horas = int.Parse(Console.ReadLine());
            Comparable num = new Suscriptor(nombre, id, meses, horas);
            if (c.Contiene(num))
            {
                Console.WriteLine("El elemnto leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }
        public static void llenarSuscriptores(Coleccionable c) 
        {
            Random r1 = new Random();
            string[] nombres = { "Juan",
                "Pedro",
                "Ana",
                "Lucía",
                "Sofía",
                "Carlos" };
            Random r2 = new Random();
            Random r3 = new Random();
            Random r4 = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[r1.Next(nombres.Length)];
                int id = r2.Next(100000, 999999);
                int m = r3.Next();
                int h = r4.Next();
                Suscriptor obj = new Suscriptor(nombre, id, m, h);
                obj.CambiarEstrategia(new EstrategiaPorID());
                c.Agregar(obj);
            }
        }
        public static void ImprimirElementos(Coleccionable c)
        {
            Iterable iterable = (Iterable)c;
            Iterador iterador = iterable.CrearNuevoIterador();
            while (!iterador.Fin())
            {
                Console.WriteLine(iterador.Actual() + " ");
                iterador.Siguiente();
            }
        }

        public static void CambiarEstrategia(Coleccionable c, EstrategiadeComparacion estrategia)
        {
            Iterable iterable = (Iterable)c;
            Iterador iterador = iterable.CrearNuevoIterador();
            while (!iterador.Fin())
            {
                Suscriptor s = (Suscriptor)iterador.Actual();
                s.CambiarEstrategia(estrategia);
                iterador.Siguiente();
            }
        }

        public static void LLenarFactory(Coleccionable c, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
                c.Agregar(comparable);
            }
        }
        
        public static void InformarFactory(Coleccionable c, int opcion)
        {
            Console.WriteLine(c.Cuantos());
            Console.WriteLine(c.Minimo());
            Console.WriteLine(c.Maximo());
            Comparable  comp= FabricaDeComparables.CrearPorTeclado(opcion);
            if (c.Contiene(comp))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }

        public static void TemporadaDeContenido(Canal canal)
        {
            for(int i = 0;i < 5; i++)
            {
                canal.PublicarContenido();
                canal.IniciarEnVivo();
            }
        }
    }

}
