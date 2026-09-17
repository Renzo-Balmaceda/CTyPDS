using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Adapter
{
    public class ReproductorMP3: IReproductor
    {
        public void Reproducir(string archivo)
        {
            Console.WriteLine("Se está reproduciendo un archivo .mp3 ");// asumo que es .Mp3
        } 
    }
}
