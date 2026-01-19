using System.Runtime.ConstrainedExecution;

namespace exercises; 

public class Produto
{
    int Id;
    string Nome;
    decimal Valor;

    public Produto(int id, string nome, decimal valor)
    {
        Id = id; 
        Nome = nome;
        Valor = valor;
    }

    public string Imprimir()
    {
        return string.Format($"id: {Id} nome: {Nome} Valor: {Valor}");
    }

}

public class Pedido
{
    int Id;
    DateTime Hora = DateTime.Now;
    string Usuario;
    string[] Produtos;

    public void AdicionarProdutos(Produto produto)
    {
        
    }

    public void CalcularTotal()
    {
        
    }

    public void FinalizarPedido()
    {
        
    }

}

public class Usuario  
{
    string Nome;
    string Telefone;
    string[] Pedidos;

    public void FazerPedido(Restaurante restaurante, Pedido pedido)
    {
        
    }

    public void VerPedidosAnteriores()
    {
        
    }
    

}

public class Restaurante
{
    string[] Produtos = new string[10];
    string[] Lista = new string[10];


    public static void CadastrarProduto()
    {
        Console.WriteLine("Digite nome produto ");
        string newprodutoNome = Console.ReadLine();
        Console.WriteLine("Digite preco ");
        decimal newprodutoPreco = decimal.Parse(Console.ReadLine());

        var p = new Produto(1, newprodutoNome, newprodutoPreco);
       
    }

    public void BuscarProdutoPorId(int id)
    {
        
    }

    public void ListarProdutosDisponiveis()
    {
        foreach (var p in Produtos)
        {
            Console.WriteLine(p);
        }
    }
}
