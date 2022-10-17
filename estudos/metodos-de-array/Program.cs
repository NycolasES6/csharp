using System;

namespace Curso_de_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[4]{"escova" , "pente" , "jogo" , "planilha"};
            string[] array2 = new string[4];
            string[] array3 = new string[4];
            string item;
            

            //Public static in BinarySearch(array,valor);
            Console.WriteLine("---BinarySearch---");
            item = "pente";
            int pos = Array.BinarySearch(array1 ,item);
            Console.WriteLine("O item {0} está na posição {1}.",item,pos);
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- ---\n");


            //Public void Copy(Ar_origem,Ar_destino,qtde_elementos);
            Console.WriteLine("---Copy--");
            Array.Copy(array1,array2,array1.Length);
            foreach (var i in array2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- ---\n");

            //public void CopyTo(Ar_destino,a_partir_desta_pos)
            Console.WriteLine("---CopyTo--");
            array1.CopyTo(array3,0);
            foreach(var i in array3){
                Console.WriteLine(i);
            }
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- ---\n");

            //public int GetLowerBound(dimensão)
            Console.WriteLine("---GetLowerBound--");
            int MenorIndice = array1.GetLowerBound(0);
                Console.WriteLine(MenorIndice);
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- ---\n");
        }
    }
}
