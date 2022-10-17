using System;

namespace ArrayStruct
{
    struct Carro
    {
        public string modelo;
        public string cor;

        public void info()
        {
            Console.WriteLine("Modelo.: {0}",this.modelo);
            Console.WriteLine("Cor....: {0}",this.cor);
        }
    }

    class Program
    {
        static void Main()
        {
            Carro[] carros = new Carro[3];
            carros[0].modelo="HRV";
            carros[0].cor = "Azul";

            carros[1].modelo="Gol";
            carros[1].cor = "Prata";

            carros[2].modelo="Camaro";
            carros[2].cor = "Rosa";

            carros[0].info();

        }
    }
}