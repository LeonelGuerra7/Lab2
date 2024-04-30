using Indexadores;

class Program
{
    static void Main(string[] args)
    {
      
        Libro miLibro = new Libro(100);

        Console.WriteLine(miLibro[0]);  
        Console.WriteLine(miLibro[99]); 
        Console.WriteLine(miLibro[100]);

        miLibro[0] = "Nuevo contenido de la página 1";
        Console.WriteLine(miLibro[0]); 
    }
}