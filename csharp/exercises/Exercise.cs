
namespace csharp.exercises; 

public class Videoagame
{
    public void Ligar(bool onoff)
    {

        try
        {
            if (!onoff) throw new ArgumentException("insuficiente");;
            
        }
        catch (Exception ex){
            Console.WriteLine($"ERRO {ex}");
        };
    }
}


