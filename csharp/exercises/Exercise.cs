
namespace csharp.exercises; 

public class Videoagame
{
    public static void Ligar()
    {
        Func<int> Power = () =>
        {
            Random random = new Random();
            return random.Next(0, 1);
        };

        // com parametro, da esquerda o que a fun recebe e da direita
        //  que a fun retorna
        Func<int, bool> Ligado = numero =>
        {
          return true;
        };

        Ligado(1);
    }
}


