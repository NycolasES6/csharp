using System;

namespace argumento_out
{
    class Program
    {
        static void Main()
        {
            int divid, divis, quoc, rest;
            divid = 10;
            divis = 5;
            quoc = divide(divid , divis ,out rest);
            Console.WriteLine(quoc +" , "+rest);
        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }
    }
}
