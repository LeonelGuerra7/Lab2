using Polimorfismo;

class Program
{
    static void Main()
    {
        Celular miCelular;

        // Crear un Smartphone y llamar
        miCelular = new Smartphone("Samsung", "Galaxy S21");
        miCelular.Llamar(); 

        // Crear un Teléfono Básico y llamar
        miCelular = new TelefonoBasico("Nokia", "1100");
        miCelular.Llamar(); 
    }
}
