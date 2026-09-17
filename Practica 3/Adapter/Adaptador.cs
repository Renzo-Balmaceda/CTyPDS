using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Adapter
{
    public class AdaptadorReproductorAvanzado : IReproductor
    {
        ReproductorAvanzadoExterno adaptable;

        public AdaptadorReproductorAvanzado(ReproductorAvanzadoExterno adaptable)
        {
            this.adaptable = adaptable;
        }

        public void Reproducir(string archivo)
        {
            if (archivo.Substring(archivo.Length - 4) == ".avi")
            {
                adaptable.ReproducirArchivoAvi();
            }
            else if(archivo.Substring(archivo.Length - 4) == ".mp4")
            {
                adaptable.ReproducirArchivoMp4();
            }
        }
    }
}
