using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    //EJERCICIO 2
    public class Visualizacion : Comparable
    {
        private int cantidad;
        public Visualizacion(int c)
        {
            this.cantidad = c;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public bool SosMayor(Comparable c)
        {
            Visualizacion v= (Visualizacion) c;
            return cantidad >v.cantidad;
        }
        public bool SosIgual(Comparable c)
        {
            Visualizacion v = (Visualizacion)c;
            return cantidad == v.cantidad;
        }
        public bool SosMenor(Comparable c)
        {
            Visualizacion v = (Visualizacion)c;
            return cantidad < v.cantidad;
        }
    }
}
