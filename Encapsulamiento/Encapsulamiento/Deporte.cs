using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{

    public class Deporte
    {
        private string nombre;
        private int jugadores;

        // Propiedades para acceder a los atributos privados
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Jugadores
        {
            get { return jugadores; }
            set
            {
                // Validamos que el número de jugadores no sea negativo
                if (value >= 0)
                {
                    jugadores = value;
                }
                else
                {
                    Console.WriteLine("Error: El número de jugadores no puede ser negativo.");
                }
            }
        }

        // Método para mostrar información del deporte
        public void MostrarInformacion()
        {
            Console.WriteLine($"Deporte: {Nombre}, Jugadores: {Jugadores}");
        }
    }
}
