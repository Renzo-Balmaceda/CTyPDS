using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> cola;
        public List<Comparable> getElementos() =>cola;
        public Cola()
        {
            cola = new List<Comparable>();
        }
        public int Cuantos()
        {
            return cola.Count;
        }
        public Comparable Minimo()
        {
            Comparable menor = cola[0];
            foreach (var n in cola)
            {
                if (n.SosMenor(menor)) { menor = n; }
            }
            return menor;
        }
        public Comparable Maximo()
        {
            Comparable max = cola[0];
            foreach (var n in cola)
            {
                if (n.SosMayor(max)) { max = n; }
            }
            return max;
        }
        public void Agregar(Comparable c)
        {
            cola.Add(c);
        }
        public bool Contiene(Comparable c)
        {
            foreach (var n in cola)
            {
                if (n.SosIgual(c)) { return true; }
            }
            return false;
        }

        public Iterador CrearNuevoIterador()
        {
            return new IteradorDeCola(this);
        }
    }

    public class IteradorDeCola : Iterador
    {
        private Cola cola;
        private int indice;
        public IteradorDeCola(Cola c)
        {
            this.cola = c;
            this.Primero();
        }
        public void Primero()
        {
            this.indice = 0;
        }
        public void Siguiente()
        {
            this.indice++;
        }
        public Comparable Actual()
        {
            return cola.getElementos()[indice];
        }
        public bool Fin()
        {
            return this.indice >= cola.Cuantos();
        }
    }
}
