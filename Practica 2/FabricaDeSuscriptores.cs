using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
   public class FabricaDeSuscriptores : FabricaDeComparables
   {
        public override Comparable CrearAleatorio()
        {
            Random rnd = new Random();
            string[] nombres = ["Pedro", 
                                "Nahuel",
                                "Martiniano",
                                "Vicentico",
                                "Florentino",
                                "Fausto",
                                "Mario",
                                "Florencio",
                                "Hanna",
                                "Ana"];
            string nombre = nombres[rnd.Next(nombres.Length)];
            int dni = rnd.Next(11111111,99999999);
            int mesesSuscripcion = rnd.Next(0,1000);
            int horasVistas= rnd.Next(0,24000);
            return new Suscriptor(nombre, dni, mesesSuscripcion, horasVistas);
        }

        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("Nombre del suscriptor: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Meses de suscripción: ");
            int mesesSuscripcion= int.Parse(Console.ReadLine());
            Console.WriteLine("Horas Vistas: ");
            int horasVistas= int.Parse(Console.ReadLine());
            return new Suscriptor(nombre, dni, mesesSuscripcion, horasVistas);
        }
   }
}
