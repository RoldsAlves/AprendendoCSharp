using System;

namespace Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if(num % 3 == 0)
                {
                    Console.Write(num +", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
