using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public abstract class AprobadorDeGastos
    {
        AprobadorDeGastos? sucesor = null;

        public AprobadorDeGastos(AprobadorDeGastos sucesor)
        {
            this.sucesor = sucesor;
        }
        public virtual void Aprobar(SolicitudDeGasto s)
        {
            if (sucesor != null)
            {
                sucesor.Aprobar(s);
            }
            else
            {
                Console.WriteLine("Nadie pudo atender la petición.");
            }
        }
    }
}
