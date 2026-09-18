using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Composite
{
    public class Carpeta : IElementoSistemaArchivo
    {
        private string Nombre;
        private List<IElementoSistemaArchivo> elementos;

        public Carpeta(string nombre) 
        {
            Nombre = nombre;
            elementos = new List<IElementoSistemaArchivo>();   
        }

        public void AgregarElementos(IElementoSistemaArchivo elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar(int NivelDeIdentacion)
        {
            string identacion = "";
            for (int i = 0; i < NivelDeIdentacion; i++)
            {
                identacion += " ";
            }
            Console.WriteLine($"{identacion} {Nombre}:");
            foreach (var elemento in elementos)
            {
                elemento.Mostrar(NivelDeIdentacion*2);
            }
        }

        public int ObtenerTamaño()
        {
            int tamaño = 0;
            foreach(var elemento in elementos)
            {
                tamaño = elemento.ObtenerTamaño();
            }
            return tamaño;
        }
    }
}
