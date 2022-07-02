using System;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do Imposto de Renda");
            Console.WriteLine("Informe o seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Infomre a quantidade de dependentes: ");
            int dependentes = Convert.ToInt32(Console.ReadLine());
            double descontoINSS = DescontoINSS(salario);
            salario = salario - descontoINSS - (dependentes * 189.59);
            double aliquataIR;
            double impostoAPagar;
            string texto;
            if(salario > 4664.68)
            {
                aliquataIR = 27.5;
                impostoAPagar = (salario * 0.275) - 869.36;
            }
            else if(salario > 3751.05)
            {
                aliquataIR = 22.5;
                impostoAPagar = (salario * 0.225) - 636.13;
            }
            else if(salario > 2826.65)
            {
                aliquataIR = 15;
                impostoAPagar = (salario * 0.15) - 354.8;
            }
            else if(salario > 1903.98)
            {
                aliquataIR = 7.5;
                impostoAPagar = (salario * 0.075) - 142.8;
            }
            else
            {
                aliquataIR = 0.0;
                impostoAPagar = 0.0;
            }

            texto = "Sua alíquota de Imposto de Renda é " + aliquataIR + "% e o imposto devido é R$ " + Math.Round(impostoAPagar, 2);
            Console.WriteLine(texto);
            Console.ReadLine();
        }

        private static double DescontoINSS(double salario)
        {
            double desconto;

            if(salario > 7087.22)
            {
                desconto = (7087.22 * 0.14) - 163.82;
            }
            else if(salario > 3641.03)
            {
                desconto = (salario * 0.14) - 163.82;
            }
            else if (salario > 2427.35)
            {
                desconto = (salario * 0.12) - 91;
            }
            else if (salario > 1212)
            {
                desconto = (salario * 0.09) - 18.18;
            }
            else
            {
                desconto = salario * 0.075;
            }

            return desconto;
        }
    }
}
