using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Command
{
    public class ControlRemoto
    {
        private IComando UltimaAccion = null;

        public void Ejecutar(IComando comando)
        {
            UltimaAccion= comando;
            comando.Ejecutar();
        }

        public void DeshacerUltimo()
        {
            if(UltimaAccion != null)
            {
                UltimaAccion.Deshacer();
                UltimaAccion = null;
            }
            else
            {
                Console.WriteLine("Imposible realizar la acción");
            }
        }
    }
}
