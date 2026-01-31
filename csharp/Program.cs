
using System.Collections;

public class Program
{
    public static void Main()
    {
        void ExibirMensagem()
            {
            int chave = 1;
            string valor = "mayra";
            Dictionary<int, string> codigos = new() { [chave] = valor};
            foreach(var c in codigos)
            {
                Console.WriteLine(c.Value, c.Key);
            }
            List<int> myList = [4, 3, 24, 12];
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            //hashset
            HashSet<string> nomes = ["may", "ana", "mayra"];

            //queue com generics
            var quiu = new Queue<string>(); 
            quiu.Enqueue("a"); // adicionar mas o primeiro a sair é o primeiro a entrar lembre-se FIFO
            quiu.Enqueue("b");
            quiu.Enqueue("c");
            Console.WriteLine(quiu.Peek()); //pegar elemento do inicio
            quiu.Dequeue(); // remover elementos do inicio
            
            // queue sem generics, pode adidiconar qualquer coisa
            var quiueSemGeneric = new Queue();
             
            }
        

        ExibirMensagem();
    }
}