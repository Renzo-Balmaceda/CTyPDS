using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Supervisor : AprobadorDeGastos
    {
        private int Limite;
        public Supervisor(AprobadorDeGastos sucesor) : base(sucesor)
        {
            Limite = 1000;
        }

        public override void Aprobar(SolicitudDeGasto S)
        {
            if (S.GetMonto()<this.Limite)
            {
                Console.WriteLine("La solicitud ha sido aprobada por el Supervisor");
            }
            else
            {
                base.Aprobar(S);
            }
        }    
    }
}
