using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Fruta : Comida
    {
        protected string color;

        public Fruta(string nombre, string tipo, string color)
            : base(nombre, tipo)
        {
            this.color = color;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Tipo: {tipo}, Color: {color}");
        }
    }
}
