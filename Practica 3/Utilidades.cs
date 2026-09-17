using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Adapter
{
    public static class Utilidades
    {
        
        public static void ReproducirArchivo(IReproductor reproductor, string archivo)
        {
            reproductor.Reproducir(archivo);
        }
    }
}
