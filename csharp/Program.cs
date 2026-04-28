using csharp.exercises;


namespace csharp;



public class Program
{
    public static void Main()
    {
        var Videogame = new List<Videogames>
        {
            new() {Nome="Playstation", Ano = 2003, Jogos = 10},
            new() {Nome="xbox", Ano = 2009, Jogos = 5},
            new() {Nome="Switch", Ano = 2015, Jogos = 15},
            new() {Nome="3DS", Ano = 2009, Jogos = 2},
        };

        var qtd = Videogame
            .Where(a => a.Jogos <= 5)
            .OrderBy(a => a.Jogos);
        foreach (var v in qtd)
        {
            // Console.WriteLine(v.Nome);
        }

        var nomes = Videogame
            .OrderBy(a => a.Nome)
            .Select(a => a.Nome);
        foreach (var g in nomes)
        {
            Console.WriteLine(g);
            Console.WriteLine("-------------");
        }

        var nomesConsoles =  
            from games in Videogame
            where games.Jogos <= 10
            orderby games.Jogos
            select games.Nome; 

        foreach (var g in nomesConsoles)
        {
            Console.WriteLine(g);
        }
    
        var xbox = Videogame.Single(g => g.Nome.Equals("xbox"));
        Console.WriteLine($"{xbox.Nome} {xbox.Jogos}");

        var nulo = Videogame.FirstOrDefault(g => g.Nome.Equals("retroid"));
        if (nulo == null) Console.WriteLine("nulo");

        var pular = Videogame.Skip(1).Take(3);
        foreach (var g in pular)
        {
            Console.WriteLine(g.Nome); // pulou playstation
        }

        var maxJogos = Videogame.Max(j => j.Jogos); //tem minimo tambem .Min
        Console.WriteLine(maxJogos); 

        // tem .Average .Sum
    } 
}