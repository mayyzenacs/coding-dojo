using System.Data.Common;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using exercises; 

namespace csharp;

public class Program
{
    // O args chega preenchido pelo SO.
    public static void Main() 
    {
        var p1 = new Produto(1, "hamburguer de queijo", 29.9m);
        var p2 = new Produto(2, "Batata", 29.9m);
        var p3 = new Produto(3, "salada", 29.9m);
        var p4 = new Produto(4, "Hamrbuguer sem qeuijo", 29.9m);
        var p5 = new Produto(5, "Refrigante laranja", 29.9m);
        
        var r = new Restaurante();

        Console.WriteLine("bem vindo a mayyzena hotdog e tals");
        Console.WriteLine("Escolha um numero do menu faz favor");
        Console.WriteLine("MENU \n 1 - Fazer novo pedido \n 2- Ver pedidos anteriores \n 3 -Sair");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            r.ListarProdutosDisponiveis();  
            
            int choice;
            do
                {
                    Console.WriteLine("Adicione produtos pelo id, aperte 0 para sair");
                    choice = int.Parse(Console.ReadLine());
                }
            while (choice > 0);

            break;
            case 2:
            // resolver porque cadastrar produtos nao ta funcionando pra cadastrar
            break;
            case 3:
            break;
        }
    }
}