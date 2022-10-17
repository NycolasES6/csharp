using System;

    class Base
    {
        public Base()
        {
            Console.WriteLine("Contrutor da classe Base");
        }

        virtual public void info()
        {
            Console.WriteLine("Base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Contrutor da classe Detivada1");
        }

        override public void info()
        {
            Console.WriteLine("Derivada1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Contrutor da classe Detivada2");
        }
        override public void info()
        {
            Console.WriteLine("Derivada2");
        }
    }

    class Program
    {
        static void Main()
        {
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            Base Ref;

            Ref = derivada1;
            Ref.info();

            Ref = derivada2;
            Ref.info();
        }
    }
