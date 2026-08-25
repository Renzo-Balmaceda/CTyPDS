using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Playlist : Coleccionable , Iterable
    {
        private List<Comparable> elementos;
        public List<Comparable> getElementos() => elementos;
        public Playlist()
        {
            elementos= new List<Comparable>();
        }

        public void Agregar(Comparable elemento)
        {
            if (!Pertenece(elemento))
            {
                elementos.Add(elemento);
            }
        }

        public bool Pertenece(Comparable elemento)
        {
            foreach (Comparable elem in elementos)
            {
                if (elem.SosIgual(elemento)) return true;
            }
            return false;
        }
        public int Cuantos() { return elementos.Count; }
        
        public Comparable Minimo()
        {
            Comparable menor = elementos[0];
            foreach (var n in elementos)
            {
                if (n.SosMenor(menor)) { menor = n; }
            }
            return menor;
        }

        public Comparable Maximo()
        {
            Comparable mayor = elementos[0];
            foreach (var n in elementos)
            {
                if (n.SosMayor(mayor)) { mayor = n; }
            }
            return mayor;
        }

        public bool Contiene(Comparable c)
        {
            return Pertenece(c);
        }

        public Iterador CrearNuevoIterador()
        {
            return new IteradorDePlaylist(this);
        }


    }

    public class IteradorDePlaylist : Iterador
    {
        private Playlist playlist;
        private int indice;
        public IteradorDePlaylist(Playlist playlist)
        {
            this.playlist = playlist;
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
            return playlist.getElementos()[indice];
        }
        public bool Fin()
        {
            return this.indice >= playlist.Cuantos();
        }
    }
}
