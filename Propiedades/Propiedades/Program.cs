using Propiedades;

{
    static void Main()
    {
        Persona persona1 = new Persona();

        
        persona1.Nombre = "Leonel";
        persona1.Edad = 19;

   
        Console.WriteLine("Nombre: " + persona1.Nombre);
        Console.WriteLine("Edad: " + persona1.Edad);

       
        try
        {
            persona1.Nombre = ""; 
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        try
        {
            persona1.Edad = 200; // Esto generará una excepción
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}