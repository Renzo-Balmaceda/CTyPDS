using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    //Clase auxiliar
   public static class Utilidades
   { 
        public static void LLenar(Coleccionable c)//EJERCICIO 5
        {
            Random n = new Random();
            for (int i = 0; i < 20; i++)
            {
                int numero = n.Next();
                Comparable num = new Visualizacion(numero);
                c.Agregar(num);
            }
        }

        public static void Informar(Coleccionable c)//EJERCICIO 6
        {
            Console.WriteLine(c.Cuantos());
            Console.WriteLine(c.Minimo());
            Console.WriteLine(c.Maximo());
            Console.WriteLine("Nombre:");
            string nombre= Console.ReadLine();
            Console.WriteLine("Meses de suscripcion: ");
            int meses= int.Parse(Console.ReadLine());
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de horas vistas:");
            int horas= int.Parse(Console.ReadLine());
            Comparable num = new Suscriptor(nombre,id, meses,horas);
            if (c.Contiene(num))
            {
                Console.WriteLine("El elemnto leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }

        public static void llenarSuscriptores(Coleccionable c) //EJERCICIO 12
        {
            Random r1 = new Random();
            string[] nombres = { "Juan",
                                "Pedro", 
                                "Ana", 
                                "Lucía", 
                                "Sofía", 
                                "Carlos" };
            Random r2= new Random();
            Random r3= new Random();
            Random r4=new Random();
            for(int i=0; i<20; i++)
            {
                string nombre = nombres[r1.Next(nombres.Length)];
                int id = r2.Next(100000, 999999);
                int m = r3.Next();
                int h = r4.Next();
                Comparable obj = new Suscriptor(nombre,id,m,h);
                c.Agregar(obj);
            }
        }
    }
}
