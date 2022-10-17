using System;

namespace Curso_de_csharp
{
    class Jogador
    {
        private int energia;
        private string nome;
        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }

        public int getEnergia()
        {
            return energia;
        }
        public string getNome()
        {
            return nome;
        }
    }

    class Aula
    {
        static void Main(){
            Jogador j1 = new Jogador("Bruno");
            
            Console.WriteLine("Nome.....{0}", j1.getNome());
            Console.WriteLine("Energia..{0}",j1.getEnergia());
        }
    }
}
