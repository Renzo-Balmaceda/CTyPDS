using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class SolicitudDeGasto
    {
        private int Monto;
        private string Descripcion;

        public SolicitudDeGasto(int monto, string descripcion)
        {
            Monto = monto;
            Descripcion = descripcion;
        }

        public int GetMonto() {  return this.Monto; }

        public string GetDescripcion() { return this.Descripcion; }
    }
}
