using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Propiedades
{
    public class Persona
    {
        private string nombre;
        private int edad;

        // Propiedad Nombre
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
            }
        }

        // Propiedad Edad
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    edad = value;
                }
                else
                {
                    throw new ArgumentException("La edad debe estar en el rango de 0 a 150 años.");
                }
            }
        }
    }

 




}
