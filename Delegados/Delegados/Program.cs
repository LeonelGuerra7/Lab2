using Delegados;

class Program
{
    static void Main()
    {
        Calculadora miCalculadora = new Calculadora();

        // Asignamos el método Sumar al delegado
        OperacionDelegate operacion = miCalculadora.Sumar;

        int resultadoSuma = operacion(10, 5);
        Console.WriteLine("Resultado de la suma: " + resultadoSuma);

        // Ahora asignamos el método Restar al delegado
        operacion = miCalculadora.Restar;

        int resultadoResta = operacion(10, 5);
        Console.WriteLine("Resultado de la resta: " + resultadoResta);
    }
}
