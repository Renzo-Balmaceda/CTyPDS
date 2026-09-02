using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    //EJERCICIO 12
    public abstract class FabricaDeComparables
    {
        public static Comparable CrearAleatorio(int opcion) 
        {
            FabricaDeComparables fabrica = null;

            switch (opcion) 
            {
                case 0: 
                    fabrica = new FabricaDeVisualizaciones();
                    break;
                case 1:
                    fabrica = new FabricaDeSuscriptores();
                    break;
                case 2:
                    fabrica = new FabricaDeCanales();
                    break;
            }
            return fabrica.CrearAleatorio();
        }

        public static Comparable CrearPorTeclado(int opcion) 
        {
            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 0:
                    fabrica = new FabricaDeVisualizaciones();
                    break;
                case 1:
                    fabrica = new FabricaDeSuscriptores();
                    break;
                case 2:
                    fabrica = new FabricaDeCanales();
                    break;
            }
            return fabrica.CrearPorTeclado();
        }

        public abstract Comparable  CrearAleatorio();

        public abstract Comparable CrearPorTeclado();
    }
}
