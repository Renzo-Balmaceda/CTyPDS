using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{ 
    //EJERCICIO 10
    public class GeneradorDeDatosAleatorios
    {
        public int NumeroAleatorio(int max)
        {
            Random rnd = new Random();
            int numero= rnd.Next(0,max);
            return numero;
        }

        public string StringAleatorio(int cant)
        {
            string palabra = "";
            const string letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghiklmnñopqrstuvwxyz";
            Random rnd = new Random();
            for(int i = 0; i < cant; i++)
            {
                palabra += letras[rnd.Next(letras.Length)];
            }

            return palabra;
        }
    }
    
}
