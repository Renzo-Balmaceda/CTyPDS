using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Composite
{
    public class Archivo : IElementoSistemaArchivo
    {
        private string Nombre;
        private int Tamaño;
        public Archivo(string nombre, int tamaño)
        {
            Nombre = nombre;
            Tamaño = tamaño;
        }
        public int ObtenerTamaño()
        {
            return Tamaño;
        }

        public void Mostrar(int NivelDeIdentacion)
        {
            string identacion = "";
            for(int i=0; i< NivelDeIdentacion; i++)
            {
                identacion += " ";
            }
            Console.WriteLine($"{identacion} {Nombre}");
        }
    }
}
