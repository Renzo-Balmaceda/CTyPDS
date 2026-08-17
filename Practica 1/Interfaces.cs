using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public interface Comparable  //EJERCICIO 1 
    {
        public bool SosIgual(Comparable c);
        public bool SosMenor(Comparable C);
        public bool SosMayor(Comparable C);
    }

    public interface Coleccionable
    {
        public int Cuantos();
        public Comparable Minimo();
        public Comparable Maximo();
        public void Agregar(Comparable c);
        public bool Contiene(Comparable c);
    }
}
