using System;

abstract class Veiculo //Classe base abstrata
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    
    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
    public int getVelAtual()
    {
        return velAtual;
    }
    abstract public void Aceleracao(int mult);
}

class Carro:Veiculo
{
    public Carro()
    {
        velMaxima = 120;
    }
    override public void Aceleracao(int mult)
    {
        velAtual+=10*mult;
    }
}

class Program
{
    static void main()
    {
        Carro carro1 = new Carro();
        Console.WriteLine(carro1.getVelAtual());
    }
}
