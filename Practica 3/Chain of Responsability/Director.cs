using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Director : AprobadorDeGastos
    {
         private AprobadorDeGastos sucesor = null;

        public Director() : base(null) { }
        public override void Aprobar(SolicitudDeGasto S)
        {
            Console.WriteLine("La solicitud se ha aprobado por el Director");
        }
    }
}
