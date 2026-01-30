
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
            
            }
        

        ExibirMensagem();
    }
}