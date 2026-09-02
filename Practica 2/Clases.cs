using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica_2
{
    public abstract class Perfil : Comparable 
    {
        protected string Nombre;
        protected int id;
        public Perfil(string nombre, int id)
        {
            Nombre = nombre;
            this.id = id;
        }
        public int getId() { return id; }
        public string getNombre() { return Nombre; }

        public virtual bool SosMenor(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id < p.getId();
        }
        public  virtual bool SosMayor(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id > p.getId();
        }
        public virtual bool SosIgual(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id == p.getId();
        }
    }
    public class Suscriptor : Perfil, Observador, Mostrable
    {
        private EstrategiadeComparacion estrategia;
        private int mesesdeSuscripcion;
        private int HorasVistas;
        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            mesesdeSuscripcion = c;
            HorasVistas = h;
            estrategia = new EstrategiaPorNombre(); //Estrategia por defecto
        }
        public void CambiarEstrategia(EstrategiadeComparacion nuevaEstrategia)
        {
            estrategia=nuevaEstrategia;
        }
        public int getHorasVistas() { return this.HorasVistas; }
        public int getMesesdeSuscripcion() { return this.mesesdeSuscripcion; }

        public override bool SosMenor(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            return estrategia.SosMenor(this, p);
        }
        public override bool SosIgual(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            return estrategia.SosIgual(this, p);
        }
        public override bool SosMayor(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            return estrategia.SosMayor(this, p);
        }
        public override string ToString()
        {
            return $"Suscriptor: {Nombre} | ID: {id} | Meses: {mesesdeSuscripcion} | Horas vistas: {HorasVistas}";
        }

        public void  VerContenido()
        {
            Console.WriteLine("Viendo el contenido");
        }
        public void ReaccionarNotificacion()
        {
            string[] frase = ["Abriendo la notificación", 
                              "Lo veo después",
                              "Silenciando notificaciones"];
            Random rnd = new Random();
            string frase_elegida = frase[rnd.Next(frase.Length)];
            Console.WriteLine(frase_elegida);
        }

        public void Actualizar(Observado o)
        {
            Canal canal = (Canal)o;
            if(canal.GetUltimoEvento() == "video")
            {
                VerContenido();
            }else if(canal.GetUltimoEvento()== "vivo")
            {
                ReaccionarNotificacion();
            }
        }
        public string MostrarInfo()
        {
            return $"{Nombre} - {HorasVistas} horas vistas";
        }

        public Suscriptor GetSuscriptor()
        {
            return this;
        }
    }

}
