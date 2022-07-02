using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro para calculuar o seu fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = numero;
            for (int num = 1; num <= numero; num++)
            {
                if (num == numero) break;
                fatorial *= num;
                Console.WriteLine(numero + " x " + num + " = " + fatorial);
            }
            Console.WriteLine("O fatorial de " + numero + " é igual a " + fatorial);
            Console.WriteLine("Tecle Enter para fechar...");
            Console.ReadLine();
        }
    }
}
