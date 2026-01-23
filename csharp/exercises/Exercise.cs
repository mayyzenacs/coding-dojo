namespace csharp.exercises; 

public class CalculadoraEstatica
{
    public static int Somar(int a, int b)
    {
        return a +b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
}

public class Executar
{
    public static void Execution()
    {
        var r = CalculadoraEstatica.Multiplicar(2, 5);

        Console.WriteLine(CalculadoraEstatica.Somar(2,5));
    }
}