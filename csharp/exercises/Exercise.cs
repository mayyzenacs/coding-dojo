
namespace csharp.exercises; 

public abstract class Videoagame
{
    public abstract string Nome();

}

public class Playstation : Videoagame
{
    public override string Nome()
    {
        return "ola, sou da playstation";
    }
}


