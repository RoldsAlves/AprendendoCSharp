using System;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Calcula Poupança.");

            double investimento = 1000;
            int mesesInvestimento = 12;

            for(int mes = 1; mes <= mesesInvestimento; mes++)
            {
                // rendimento de 0.5% (0.005) ao mês
                investimento *= 1.005;
                Console.WriteLine("No mês " + mes + "você tem R$ " + investimento);
            }

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
