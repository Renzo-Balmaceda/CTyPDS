using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class PreparadorDeTe : PreparadorDeBebida
    {
        public override void AgregarBaseDeSaborizante()
        {
            Console.WriteLine("Se ha agregado saquito de té de frutos silvestres.");
        }

        public override void AgregarCondimentos()
        {
            Console.WriteLine("Se ha añadido miel pura.");
            Console.WriteLine("Se ha añadido jugo de limón.");
        }
    }
}
