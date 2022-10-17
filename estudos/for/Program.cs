using System;

namespace loopfor
{
    class Program
    {
        static void Main()
        {
            string[] p = new string[3];
            p[0] = "Qual o seu nome ?";
            p[1] = "Onde você mora ?";
            p[2] = "De qual animal você mais gosta ?";

            string[] r = new string[3]; 
            
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(p[i]);
                r[i] = Console.ReadLine();
            }
            Console.WriteLine("Fim da execução do prgrama.\n\n");

            int u = 0;
            while (u <=4)
            {
                Console.WriteLine(u);
                u++;
            }

        }
    }
}
