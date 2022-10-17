using System;

namespace sobrecarga_de_metodos
{
    class Calc
    {
        public int soma(params int[]n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }

        public double soma(params double[]n)
        {
            double s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s +=n[i];
            }
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            int res;

            Calc calc = new Calc();
            res = calc.soma(10,5);

            Console.WriteLine(res);
        }
    }
}
