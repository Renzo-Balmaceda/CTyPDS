using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public  class Gerente : AprobadorDeGastos
    {
        private int Limite;
        public Gerente(AprobadorDeGastos sucesor): base(sucesor)
        {
            Limite = 5000;
        }

        public override void Aprobar(SolicitudDeGasto S)
        {
            if (S.GetMonto() < this.Limite)
            {
                Console.WriteLine("La solicitud ha sido aprobada por Gerente ");
            }
            else
            {
                base.Aprobar(S);
            }
        }
    }
}
