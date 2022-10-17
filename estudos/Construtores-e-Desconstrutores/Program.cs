using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador foi destruido.");
    }
}

class aula
{
    static void Main()
    {
        Jogador j1 = new Jogador("Nycolas");
        Console.WriteLine("Jogador 1 tem {0} pontos de vida.", j1.energia);  
    }
} 