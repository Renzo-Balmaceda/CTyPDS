using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class PreparadorDeCafé : PreparadorDeBebida
    {
        public override void AgregarBaseDeSaborizante()
        {
            Console.WriteLine("Se ha agregado café instantáneo.");
        }
    }
}
