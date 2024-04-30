using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst
{
    public abstract class Vehiculo
    {
        public abstract void MostrarInformacion();
    }

    public class Carro : Vehiculo
    {
        // Atributos
        private string marca;
        private string modelo;
        private int año;
        private float precio;

        // Constructor
        public Carro(string marca, string modelo, int año, float precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.precio = precio;
        }

        // Implementación del método abstracto
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Año: {año}, Precio: Q{precio}");
        }
    }
}