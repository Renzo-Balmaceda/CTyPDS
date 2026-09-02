using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class FabricaDeCanales : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            Random rnd = new Random();
            string[] nombres_canales = ["Los Blogs de Renzo", 
                                        "DailyTech", 
                                        "Visual Studio 2022",
                                        "El Manual de C#",
                                        "Nombre Random"];
            string n = nombres_canales[rnd.Next(nombres_canales.Length)];
            return new Canal(n);
        }

        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese nombre del Canal a crear: ");
            string nombre= Console.ReadLine();
            return new Canal(nombre);
        }   
    }
}
