using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{

    public class Celular
    {
        protected string marca;
        protected string modelo;

        public Celular(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual void Llamar()
        {
            Console.WriteLine($"Llamando desde {marca} {modelo}");
        }
    }
}
