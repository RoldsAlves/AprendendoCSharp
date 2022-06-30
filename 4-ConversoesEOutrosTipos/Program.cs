using System;

namespace _4_ConversoesEOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - Conversões e Outros Tipos.");
            double salario = 3200.10;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //O long é um tipo de variável que suporta até 64 bits
            long x = 2000000000000000;
            Console.WriteLine(x);

            short y = 15000;
            Console.WriteLine(y);

            float altura = 1.62f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
