using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    //EJERCICIO 4
    public class Pila : Coleccionable
    {
        private List<Comparable> pila;
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
            foreach(var n in pila)
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
    }

    public class Cola : Coleccionable
    {
        private List<Comparable> cola;
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
            foreach(var n in cola)
            {
                if (n.SosMenor(menor)) { menor = n; }
            }
            return menor;
        }
        public Comparable Maximo()
        {
            Comparable max = cola[0];
            foreach(var n in cola)
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
            foreach(var n in cola)
            {
                if (n.SosIgual(c)) { return true; }
            }
            return false;
        }
    }
}
