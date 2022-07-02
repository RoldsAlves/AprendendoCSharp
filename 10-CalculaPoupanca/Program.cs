using System;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calcula Poupança.");

            double investimento = 1000;
            int mesesInvestimento = 12;
            int mes = 1; 

            while (mes <= mesesInvestimento)
            {
                // rendimento de 0.5% (0.005) ao mês
                investimento = investimento + (investimento * 0.005);
                Console.WriteLine("No mês " + mes + "você tem R$ " + investimento);
                mes++;
            }

            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
