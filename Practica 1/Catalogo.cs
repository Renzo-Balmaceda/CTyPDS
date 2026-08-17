using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Catalogo : Coleccionable
    {
        private Pila pila;
        private Cola cola;
        public Catalogo(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int Cuantos()
        {
            int cont= pila.Cuantos()+cola.Cuantos();
            return cont;
        }

        public Comparable Minimo()
        {
            if (pila.Minimo().SosMenor(cola.Minimo())) 
            { 
                return pila.Minimo(); 
            }
            else
            {
                return cola.Minimo();
            }
        }

        public Comparable Maximo()
        {
            if (pila.Maximo().SosMayor(cola.Maximo()))
            {
                return pila.Maximo();
            }
            else
            {
                return cola.Maximo();
            }
        }

        public void Agregar(Comparable c) { }
        public bool Contiene(Comparable c)
        {
            if (pila.Contiene(c)|| cola.Contiene(c))
            {
                return true;
            }
            else { return false; }
        }
    }
}
