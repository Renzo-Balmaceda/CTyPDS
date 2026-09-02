using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    //EJERCICIO 11
    public class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public string StringPorTeclado()
        {
            string str = Console.ReadLine();
            return str;
        }
    }
}
