using System;

class Program
{
    static void Main()
    {
        const decimal taxa_dolar = 4.19m;

        Console.WriteLine("Digite seu nome:");
        string nomeUsuario = Console.ReadLine();

        Console.WriteLine("Digite o valor");
        string entrada = Console.ReadLine();
        decimal valor = decimal.Parse(entrada);

        decimal imposto = 0.01m;
        decimal valor_imposto = valor + (valor * 0.01m);

        decimal valor_usd = valor_imposto / taxa_dolar;
        bool conversaoSucesso = valor_usd > 0;
        string idTransacao = nomeUsuario + "-" + 3934922;

        Console.WriteLine($"Oi {nomeUsuario} o valor {valor} fica {valor_imposto} com imposto de 1% e em dolar fica {valor_usd:F2}");
        Console.WriteLine($"Transação feita com sucesso? {conversaoSucesso}");
        Console.WriteLine($"Id da transacao: {idTransacao}");

    }
}