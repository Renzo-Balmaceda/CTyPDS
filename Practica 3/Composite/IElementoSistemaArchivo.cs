using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Composite
{
    public interface IElementoSistemaArchivo
    {
        public int ObtenerTamaño();

        public void Mostrar(int NivelDeIdentacion);

    }
}
