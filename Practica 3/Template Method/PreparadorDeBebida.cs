using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public abstract class PreparadorDeBebida
    {
        public void PrepararBebida()
        {
            HervirAgua();
            AgregarBaseDeSaborizante();
            VerterEnTaza();
            AgregarCondimentos();
        }

        public void HervirAgua()
        {
            Console.WriteLine("Calentando agua...");
            Thread.Sleep(1500);
            Console.WriteLine("El agua ha hervido.");
        }

        public abstract void AgregarBaseDeSaborizante();

        public void VerterEnTaza()
        {
            Console.WriteLine("El contenido ha sido vertido en la taza.");
        }

        public virtual void AgregarCondimentos()
        {
            Console.WriteLine("Agregando condimentos...");
        }
    }
}
