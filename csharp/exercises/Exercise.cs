
namespace csharp.exercises; 

public class Carro(string nome, int velocidade, string modelo)
{
    protected string Nome = nome;
    protected int Velocidade = velocidade;
    public string Modelo = modelo;

    public int Acelerar(int kmh)
    {
        if (kmh == 0) kmh = 0;

        if (kmh > 0) kmh += 5;

        return kmh;
    }
}

public class CarroFeio(string nome, int velocidade, string modelo, int rodas) : Carro(nome, velocidade, modelo)
{
    public string Desc()
    {
        return $"carro feio {Nome} anda {Velocidade} e tem {rodas}"; 
    }
}


