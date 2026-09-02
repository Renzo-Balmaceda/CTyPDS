using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public interface Comparable 
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
    public interface Iterable
    {
        public Iterador CrearNuevoIterador();
    }
    public interface Iterador
    {
        public void Primero();
        public void Siguiente();
        public bool Fin();
        public Comparable Actual();
    }

    public interface Observador
    {
        public void Actualizar(Observado o);
    }
    public interface Observado
    {
        public void AgregarObservador(Observador o);
        public void QuitarObservador(Observador o);

        public void Notificar();
    }
    public interface Mostrable
    {
        public string MostrarInfo();
        public Suscriptor GetSuscriptor();
    }
}
