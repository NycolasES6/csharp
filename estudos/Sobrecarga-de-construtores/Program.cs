using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Davi";
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi destrido", nome);
    }
}

class aula
{
    static void Main()
    {
        Jogador j1 = new Jogador("Nycolas", 100);
        Jogador j2 = new Jogador("Átylas");
        Jogador j3 = new Jogador();

        Console.WriteLine("Jogador {0} tem {1} pontos de vida.", j1.nome, j1.energia);
        Console.WriteLine("Jogador {0} tem {1} pontos de vida.", j2.nome, j2.energia);
        Console.WriteLine("Jogador {0} tem {1} pontos de vida.", j3.nome, j3.energia);
    }
} 