using Encapsulamiento;

class Program
{
    static void Main()
    {
        Deporte futbol = new Deporte();
        futbol.Nombre = "Fútbol";
        futbol.Jugadores = 22;

        futbol.MostrarInformacion(); 
        futbol.Jugadores = -5; 
    }
}
