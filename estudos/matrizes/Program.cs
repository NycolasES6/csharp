using System;

namespace matrizes
{
    class Program
    {
        static void Main()
        {
            string[,] c = new string[2,4];
            c[0,0] = "Nome";    c[1,0] = "Idade";
            c[0,1] = "Nycolas"; c[1,1] = "15";
            c[0,2] = "Átylas";  c[1,2] = "16";
            c[0,3] = "Paulo";   c[1,3] = "45";
            Console.WriteLine("O funcionário {0} tem {1} anos de idade", c[0,1] , c[1,1]);
             Console.WriteLine("O funcionário {0} tem {1} anos de idade", c[0,2] , c[1,2]);
              Console.WriteLine("O funcionário {0} tem {1} anos de idade", c[0,3] , c[1,3]);

        }
    }
}
