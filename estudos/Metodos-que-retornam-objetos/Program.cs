using System;

namespace Metodos_que_retornam_objetos
{
    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;

        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }

        public Ovo botar()
        {
            numOvo++;
            return new Ovo(numOvo, nomeGalinha);
        }
    }

    class Ovo
    {
        private int numOvo;
        private string MinhaGalinha;

        public Ovo(int numOvo, string MinhaGalinha)
        {
            this.MinhaGalinha = MinhaGalinha;
            this.numOvo = numOvo;
            Console.WriteLine("A galinha {0} botou {1} Ovo(s)",MinhaGalinha,numOvo);
        }
    }


    class Program
    {
        static void Main()
        {
            Galinha g1 = new Galinha("Benedita");
            Galinha g2 = new Galinha("Gertrudiz");
            Galinha g3 = new Galinha("Maria");

            g1.botar();

            g2.botar();
            g2.botar();

            g3.botar();
            g3.botar();
            g3.botar();
        }
    }
}
