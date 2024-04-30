using Abst;
using System;

class Program
{
    static void Main()
    {
        // Crear un objeto carro
        Vehiculo miCarro = new Carro("Toyota", "Corolla", 2022, 90000);

        // Llamar al método para mostrar información
        miCarro.MostrarInformacion();
    }
}
