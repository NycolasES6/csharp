using System;

namespace Curso_de_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[4];

            for(int i =0 ; i <=3; i++){
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("\n\nSeus amigos são :");

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
