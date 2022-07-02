using System;

namespace _13_EncadeandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - Encadeando FOR");

            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
