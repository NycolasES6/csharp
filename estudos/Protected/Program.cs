using System;

namespace Curso_de_csharp
{
    class Veiculo
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;
        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }
        public bool getLigado()
        {
            return ligado;
        }

        public int getVelMax()
        {
            return velMax;
        }
    }

    class Carro:Veiculo
    {
        public string nome;
        public Carro(string nome, int vm):base(vm)
        {//Derivada de veículo
        this.nome = nome;
        ligado = true;
        }
    }

    class Program
    {
        static void Main()
        {
            Carro carro = new Carro("Bonitão", 1200);

            Console.WriteLine("Nome:",carro.nome);
            Console.WriteLine("Ligado:",carro.getLigado());
            Console.WriteLine("Nome:",carro.getVelMax());
        }
    }
}
