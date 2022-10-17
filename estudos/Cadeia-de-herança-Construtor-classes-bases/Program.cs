using System;

namespace Heranca
{
    class Veiculo
    {//classe base
        public int velMax;
        private bool ligado;
        private int rodas;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return ligado?"Sim":"Não";
        }

        public int getRodas()
        {
            return rodas;
        }
    }


    class Carro:Veiculo
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(7)
        {
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class Program
    {
        static void Main()
        {
            Carro c1 = new Carro("Rapidão", "Vermelho");

            Console.WriteLine("Cor:{0}", c1.cor);
            Console.WriteLine("Nome:{0}", c1.nome);
            Console.WriteLine("Rodas:{0}", c1.getRodas());
            Console.WriteLine("Vel.Máxima:{0}", c1.velMax);
            Console.WriteLine("Ligado:{0}", c1.getLigado());
        }
    }
}
