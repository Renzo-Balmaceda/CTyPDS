using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Command
{
    public interface IComando
    {
        public void Ejecutar() { }

        public void Deshacer() { }
    }
}
