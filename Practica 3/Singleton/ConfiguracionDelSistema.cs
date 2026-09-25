using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Singleton
{
    public class ConfiguracionDelSistema
    {
        private static ConfiguracionDelSistema instancia=null;
        private Dictionary<string, int> Claves; 
        private ConfiguracionDelSistema()
        {
            Claves= new Dictionary<string, int>();
        }

        public static ConfiguracionDelSistema ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ConfiguracionDelSistema();
            return instancia;
        }

        public void EstablecerValor(string clave, int valor)
        {
            Claves.Add(clave, valor);
            Console.WriteLine($"Clave añadida: {clave}");
        }

        public int ObtenerValor(string clave)
        {
            return Claves[clave];
        }

    }
}
