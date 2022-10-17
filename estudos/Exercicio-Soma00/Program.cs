using System;

namespace Curso_de_csharp
{
    public class Conta
    {
        int res;
        int n1;
        int n2;
        public Conta()
        {
            Console.WriteLine("Escolha um número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha um outro número");
            n2 = int.Parse(Console.ReadLine());
        }

        public void Operacao()
        {
            Console.WriteLine("Qual operação deseja fazer\n(a)...Adição\n(b)...Subtração");
            string oprc = Console.ReadLine();
            if (oprc == "a" | oprc == "A")
            {
                res = n1 + n2;
                oprc = "adição";
            }
            else if (oprc == "b" | oprc == "B")
            {
                res = n1 - n2;
                oprc = "Subtração";
            }
            Console.WriteLine("O resultado da {0} entre {1} e {2} é {3}", oprc, n1, n2, res);
        }
    }
    class Program
    {
        static void Main()
        {
            Conta soma = new Conta();
            soma.Operacao();
        }
    }
}
