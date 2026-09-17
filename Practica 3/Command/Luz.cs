using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Command
{
    public class Luz
    {
        public void Encender()
        {
            Console.WriteLine("Se ha encendido la luz.");
        }

        public void Apagar()
        {
            Console.WriteLine("Se ha apagado la luz.");
        }
    }
}
