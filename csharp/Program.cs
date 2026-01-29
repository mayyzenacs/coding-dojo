public class Validador
{
    
    public bool TentarConverter(string texto, out int resultado)
    {
        if (int.TryParse(texto, out int numeroConvertido))
        {
            resultado = numeroConvertido; // 
            return true;
        }

        resultado = 0; 
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        Validador val = new Validador();
        string input = "123";

        
        if (val.TentarConverter(input, out int numero))
        {
            Console.WriteLine($"Sucesso: {numero}");
        }
        else
        {
            Console.WriteLine("Não é um número.");
        }
    }
}