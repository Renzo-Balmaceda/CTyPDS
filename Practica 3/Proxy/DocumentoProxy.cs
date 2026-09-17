using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Proxy
{
    public class DocumentoProxy:IDocumento
    {
        DocumentoReal documento = null;

        public string Leer(string usuario)
        {
            if(usuario== "admin")
            {
                if(documento== null)
                {
                    documento = new DocumentoReal();
                }
                return documento.Leer(usuario);
            }
            else
            {
                return "No posee el permiso para realizar esta acción.";
            }
        }
    }
}
