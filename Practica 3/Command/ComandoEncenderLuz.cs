using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Command
{
    public class ComandoEncenderLuz : IComando
    {
        private Luz luz;

        public ComandoEncenderLuz(Luz luz)
        {
            this.luz = luz;
        }
        public void Ejecutar()
        {
            luz.Encender();
        }

        public void Deschacer()
        {
            luz.Apagar();
        }

    }
}
