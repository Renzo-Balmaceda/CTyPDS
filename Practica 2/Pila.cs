using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Pila : Coleccionable , Iterable
    {
        private List<Comparable> pila;
        public List<Comparable> getElementos() => pila;
        public Pila()
        {
            pila = new List<Comparable>();
        }

        public int Cuantos()
        {
            return pila.Count;
        }

        public Comparable Minimo()
        {
            Comparable menor = pila[0];
            foreach (var n in pila)
            {
                if (n.SosMenor(menor)) { menor = n; }
            }
            return menor;
        }
        public Comparable Maximo()
        {
            Comparable max = pila[0];
            foreach (var n in pila)
            {
                if (n.SosMayor(max)) { max = n; }
            }
            return max;
        }
        public void Agregar(Comparable c)
        {
            pila.Add(c);
        }
        public bool Contiene(Comparable c)
        {
            foreach (var n in pila)
            {
                if (n.SosIgual(c)) { return true; }
            }
            return false;
        }
        public Iterador CrearNuevoIterador()
        {
            return new IteradorDePila(this);
        }
    }
    public class IteradorDePila: Iterador
    {
        private Pila pila;
        private int indice;
        public IteradorDePila(Pila p)
        {
            this.pila = p;
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
            return pila.getElementos()[indice];
        }

        public bool Fin()
        {
            return this.indice >= pila.Cuantos();
        }


    }
}
