using System;

namespace Struct
{
    struct Carro
    {
        public string marca;
        public string modelo;

        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }

        public void info()
        {
            Console.WriteLine("Modelo.: {0}",this.modelo);
            Console.WriteLine("Marca..: {0}",this.marca);
            Console.WriteLine("Cor....: {0}",this.cor);
        }
    }

    class Program
    {
        static void Main()
        {
            Carro c1 = new Carro("Honda", "HRV", "Prata");
            c1.info();
        }
    }
}