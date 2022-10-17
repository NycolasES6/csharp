using System;

public class Personagem
{
    public int ataque;
    public int defesa;
    public int escudo = 5;
    public bool modo;

}

public class Definir
{
    static void Main()
    {
        Aliados();
    }

    static void Aliados()
    {
        Personagem aliado1 = new Personagem();

        Console.WriteLine("Qual o ataque do seu personagem ?");
        aliado1.ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a defesa do seu personagem ?");
        aliado1.defesa = int.Parse(Console.ReadLine());

        Inimigo();
    }
    static void Inimigo()
    {
        Personagem inimigo1 = new Personagem();

        Console.WriteLine("Qual o ataque do seu inimigo ?");
        inimigo1.ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a defesa do seu inimigo ?");
        inimigo1.defesa = int.Parse(Console.ReadLine());
    }
}