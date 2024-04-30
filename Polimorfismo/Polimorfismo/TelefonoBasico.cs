using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class TelefonoBasico : Celular
    {
        public TelefonoBasico(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override void Llamar()
        {
            Console.WriteLine($"Llamando desde {marca} {modelo} (Teléfono Básico)");
        }
    }
}
