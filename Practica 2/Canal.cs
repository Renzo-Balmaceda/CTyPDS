using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Canal : Comparable, Observado
    {
        List<Observador> Suscriptores;
        private string Nombre;
        private string UltimoEvento;
        public Canal(string nombre)
        {
            UltimoEvento = "";
            Nombre = nombre;
            Suscriptores = new List<Observador>();
        }

        public List<Observador> GetSuscriptores(){ return Suscriptores.ToList(); }
        public string GetNombre() {  return Nombre; }
        public string GetUltimoEvento() { return UltimoEvento; }
        public void PublicarContenido()
        {
            Console.WriteLine($"{this.Nombre} publicó un nuevo video.");
            UltimoEvento = "video";
            Notificar();
        }

        public void IniciarEnVivo()
        {
            Console.WriteLine($"{this.Nombre} está en vivo.");
            UltimoEvento = "vivo";
            Notificar();
        }

        public bool SosMenor(Comparable c)
        {
            Canal canal = (Canal) c;
            return Nombre.CompareTo(canal.GetNombre()) < 0;
        }

        public bool SosIgual(Comparable c)
        {
            Canal canal = (Canal) c;
            return Nombre.CompareTo(canal.GetNombre())== 0;
        }
        public bool SosMayor(Comparable c)
        {
            Canal canal = (Canal)c;
            return Nombre.CompareTo(canal.GetNombre())>0;
        }

        // EJERCICIO 17
        public void AgregarObservador(Observador o)
        {
            Suscriptores.Add(o);
        }

        public void QuitarObservador(Observador o)
        {
            Suscriptores.Remove(o);
        }

        public void Notificar()
        {
            foreach(Observador obj in Suscriptores)
            {
                obj.Actualizar(this);
            }
        }
    }
}
