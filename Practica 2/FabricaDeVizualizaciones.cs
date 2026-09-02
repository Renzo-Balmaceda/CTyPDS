using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class FabricaDeVisualizaciones : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            Random rnd = new Random();
            return new Visualizacion(rnd.Next(0, int.MaxValue));
        }

        public override Comparable CrearPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return new Visualizacion(numero); 
        }
    }
}
