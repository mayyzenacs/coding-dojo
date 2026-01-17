using exercises; 

namespace CursoBackend;

public class Program
{
    // O args chega preenchido pelo SO.
    public static void Main(string[] args) 
    {
        Usuario user = new Usuario("lucas", "231932");

        user.ApresentarStrin();
    }
}