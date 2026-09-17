using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Adapter
{
    public  class ReproductorAvanzadoExterno
    {
        public void ReproducirArchivoAvi()
        {
            Console.WriteLine("Se está reproduciendo archivo .avi ");
        }

        public void ReproducirArchivoMp4()
        {
            Console.WriteLine("Se está reproduciendo archivo .mp4 "); 
        }
    }
}
