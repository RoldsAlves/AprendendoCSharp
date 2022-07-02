using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - Trabalhando com Condicionais.");
            int idadeJoao = 16;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;
            bool grupo = false;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Você pode entrar - Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar!");
            }
            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
