using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Proxy
{
    public class DocumentoReal : IDocumento
    {
        public DocumentoReal()
        {
            Console.WriteLine("Cargando archivo...");
            Thread.Sleep(2000);
        }

        public string Leer(string usuario)
        {
            return "Contenido del documento"; 
        }

    }
}
