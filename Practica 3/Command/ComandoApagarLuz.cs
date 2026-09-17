using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Command
{
    public class ComandoApagarLuz : IComando
    {
        private Luz luz;

        public ComandoApagarLuz(Luz luz)
        {
            this.luz = luz;
        }

        public void Ejecutar()
        {
            luz.Apagar();
        }
        public void Deshacer()
        {
            luz.Encender();
        }
    }
}
