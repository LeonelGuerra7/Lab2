using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Comida
    {
        protected string nombre;
        protected string tipo;

        public Comida(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Tipo: {tipo}");
        }
    }
}
