namespace exercises; 

public class Usuario
{
    public string Nome;
    public string Telefone;

    public Usuario(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public string Apresentar()
    {
        if (!string.IsNullOrWhiteSpace(Nome))
        {
            return string.Format($"Olá {Nome} telefone {Telefone}");
            
        }
        return string.Format("nome vazio");
    }

    public void ApresentarStrin()
    {
        Console.WriteLine(Apresentar());
    }
}
