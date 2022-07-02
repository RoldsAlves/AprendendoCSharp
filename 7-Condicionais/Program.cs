using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7 - Trabalhando com Condicionais.");

            int idadeJoao = 16;
            int quantidadePessoas = 3;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos - Seja bem vindo!");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("Você não tem 18, mas pode entrar, pois está acompanhado!");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar!");
                }
            }

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
