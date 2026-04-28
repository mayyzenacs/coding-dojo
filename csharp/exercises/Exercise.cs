
using System.Net.Http.Json;

namespace csharp.exercises; 

public class Desafio
{   
    private static readonly HttpClient client = new HttpClient();

    public async Task ExecuteFirst()
    {
        try {
            var response = await client.GetAsync("");
            response.EnsureSuccessStatusCode();

            string return1 = await response.Content.ReadAsStringAsync();
            Console.WriteLine("-----------");
            Console.WriteLine($"PASSO 1: {return1}");

            var payload = new
            {
                cpf = ""
            };

            var response2 = await client.PostAsJsonAsync("", payload);

            if (response2.IsSuccessStatusCode)
            {
                string result2 = await response2.Content.ReadAsStringAsync();
                Console.WriteLine("-----------");
                Console.WriteLine($"PASSO 2: {result2}");
            } else
            {
                string err = await response2.Content.ReadAsStringAsync();
                Console.WriteLine($"ERRO ENCONTRADO: {err}");
            }

            var payload2 = new
            {
                cpf = "",
                respostaQuestaoObjetiva = "" 
            };

            var response3 = await client.PostAsJsonAsync("", payload2);

            if (response3.IsSuccessStatusCode)
            {
                string result3 = await response3.Content.ReadAsStringAsync();
                Console.WriteLine("-----------");
                Console.WriteLine($"PASSO 3: {result3}");
            } else
            {
                string err = await response3.Content.ReadAsStringAsync();
                Console.WriteLine($"ERRO ENCONTRADO: {err}");
            }

            string token = "";
            string nomeCompleto = "";
            string cpf = "";

            string url = $"https://url?cpf={cpf}&nome={nomeCompleto}&token={token}";

            var response4 = await client.GetAsync(url);

            if (response4.IsSuccessStatusCode) {
                string result4 = await response4.Content.ReadAsStringAsync();
                Console.WriteLine("-----------");
                Console.WriteLine($"PASSO 4: {result4}");
            } else {
                string err = await response4.Content.ReadAsStringAsync();
                Console.WriteLine($"ERRO ENCONTRADO: {err}");
            }
            
        } 
        catch (HttpRequestException e) {
            Console.WriteLine($"Erro {e.Message}");
        };
    }

}

