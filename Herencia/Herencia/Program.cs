using Herencia;

class Program
{
    static void Main()
    {
        Comida comida = new Comida("Manzana", "Fruta");
        comida.MostrarInformacion(); // Salida: Nombre: Manzana, Tipo: Fruta

        Fruta fruta = new Fruta("Naranja", "Fruta", "Naranja");
        fruta.MostrarInformacion(); // Salida: Nombre: Naranja, Tipo: Fruta, Color: Naranja
    }
}