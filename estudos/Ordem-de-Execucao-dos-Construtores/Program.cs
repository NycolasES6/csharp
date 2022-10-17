using System;

    class Base
    {
        public Base()
        {
            Console.WriteLine("Contrutor da classe Base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Contrutor da classe Detivada1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Contrutor da classe Detivada2");
        }
    }

    class Program
    {
        static void Main()
        {
            Derivada2 derivada2 = new Derivada2();
        }
    }
