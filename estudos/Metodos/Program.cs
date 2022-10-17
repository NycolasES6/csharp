using System;

namespace Curso_de_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ping");
            for (int i = 0; i <= 10; i++)
            {
                men();
            }
        }

        static void men()
        {
            Console.WriteLine("Pong");
        }
    }
}
