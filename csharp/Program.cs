using exercises; 

namespace CursoBackend;

public class Program
{
    // O args chega preenchido pelo SO.
    public static void Main() 
    {
        var user = Usuario.Multiplicar(2,10);
        
        Console.WriteLine(user);
    }
}