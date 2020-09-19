using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string qualquerCoisa;

            //Inicio(Escreva)//
            Console.Write("Escreva qualquer coisa: ");
            qualquerCoisa = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{qualquerCoisa}!!!".ToUpper());
            //Final(Escreva)//

            //Partida(Sair)//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //Final(Sair)//
        }
    }
}
