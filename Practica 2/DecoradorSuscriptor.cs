using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public abstract class DecoradorSuscriptor : Mostrable
    {
       protected Mostrable componente;
       public DecoradorSuscriptor(Mostrable componente)
       { 
            this.componente = componente;
       }
        public abstract  string MostrarInfo();
        public Suscriptor GetSuscriptor()
        {
            return componente.GetSuscriptor();
        }
        
    }
}
