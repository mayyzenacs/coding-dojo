using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindos ao McDonalds");

        Console.WriteLine("Digite o número do pedido desejado");
        Console.WriteLine("\n 1 - Quarteirão\n 2 - McChicken\n 3 - BigMac\n 4 - BraboMC");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch(escolha) {
            case 1:
                Console.WriteLine("Você escolheu um Quarteirão Valor R$ 29,9");
                break;
            case 2:
                Console.WriteLine("Você escolheu um McChiken Valor R$ 15,00");
                break;
            case 3:
                Console.WriteLine("Você escolheu um BigMac Valor R$ 25,9");
                break;
            case 4:
                Console.WriteLine("Você escolheu um BraboMC Valor R$ 49,9");
                break;
        }
        Console.WriteLine("Lanche não encontrado ou fora de estoque");
    }
}