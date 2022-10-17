using System;

namespace Interfaces
{
    // Interfaces só implementam métodos ou protótipos de métodos, toda classe que implementar uma interface tem que iplemetar seu métodos.Interface não tem contrutor nem desconstrutor.

    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }
    public interface Combate
    {
        void disparar();
    }

    class Carro : Veiculo, Combate
    {
        public bool ligado;
        private int municao;
        public Carro() 
        {
            setMunicao(100);
        }

        public void setMunicao(int quantidade)
        {
            this.municao = quantidade;
        }
        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        public void info(){}
    }

    class Program
    {
        static void Main()
        {
            Carro c1 = new Carro();
            Console.WriteLine(c1.ligado);
        }
    }
}
