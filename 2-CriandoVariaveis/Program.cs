using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Criando Variáveis.");
            int idade;
            idade = 32;
            Console.WriteLine("Minha idade é " + idade);
            idade = 25 - 5;
            Console.WriteLine("Minha idade é " + idade);
            idade = 5 * 2 - 6;
            Console.WriteLine("Minha idade é " + idade);
            idade = (5 * 2) - 3;
            Console.WriteLine("Minha idade é " + idade);

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
