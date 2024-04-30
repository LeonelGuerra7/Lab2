using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Libro
    {
        private string[] paginas;

        public Libro(int numPaginas)
        {
            paginas = new string[numPaginas];
  
            for (int i = 0; i < numPaginas; i++)
            {
                paginas[i] = "Contenido de la página " + (i + 1);
            }
        }

        // Indexador
        public string this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < paginas.Length)
                {
                    return paginas[indice];
                }
                else
                {
                    return "Página no encontrada";
                }
            }
            set
            {
                if (indice >= 0 && indice < paginas.Length)
                {
                    paginas[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar contenido a una página inexistente");
                }
            }
        }
    }
}
