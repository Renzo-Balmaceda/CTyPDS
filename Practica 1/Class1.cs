using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
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
        public string getNombre() {  return Nombre; }

        public bool SosMenor(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id<p.getId();
        }
        public bool SosMayor(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id>p.getId();
        }
        public bool SosIgual(Comparable c)
        {
            Perfil p = (Perfil)c;
            return id==p.getId();
        }
    }
    public class Suscriptor : Perfil
    {
        private int mesesdeSuscripcion;
        private int HorasVistas;
        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            Nombre= n;
            this.id = i;
            mesesdeSuscripcion = c;
            HorasVistas = h;
        }
        public int getHorasVistas() { return this.HorasVistas;}
        public int getMesesdeSuscripcion() { return this.mesesdeSuscripcion;}
        public bool SosMenor(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            return this.mesesdeSuscripcion < p.getMesesdeSuscripcion();
        }
        public bool SosIgual(Comparable c)
        {
            Suscriptor p = (Suscriptor)c;
            return this.mesesdeSuscripcion== p.getMesesdeSuscripcion();
        }
        public bool SosMayor(Comparable c)
        {
            Suscriptor p= (Suscriptor)c;
            return this.mesesdeSuscripcion>p.getMesesdeSuscripcion();
        }
        public override string ToString()
        {
            return id.ToString();
        }
    }

}
