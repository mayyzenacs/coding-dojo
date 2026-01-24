namespace csharp.exercises; 

public class ParametrosNomeados
{
    public static void Formatar(int dia, int mes, int ano)  {
        Console.WriteLine($"{dia:D2} {mes:D2} {ano:D2}");
    }

    public static void Execute()
    {
        Formatar(dia: 1, mes: 5, ano:2026);
    }
}

