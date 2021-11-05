using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double dbNumero;
            bool vfNumero, vfDbNumero;
            string dsNumero, dsDbNumero;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----- Análise de Números -----\n");
            Console.ResetColor();

            Console.WriteLine("Insira um número inteiro\ne pressione 'Enter' para\nser analisado!\n");

            Console.Write("Número..: ");
            dsNumero = Console.ReadLine();
            dsDbNumero = dsNumero;

            vfNumero = Int32.TryParse(dsNumero, out numero);
            vfDbNumero = Double.TryParse(dsDbNumero, out dbNumero);

            if (vfNumero)
            {

                if (numero < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n* {numero} é um número inteiro negativo!\n");
                    Console.ResetColor();
                }
                if (numero > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n* {numero} é um número inteiro positivo!\n");
                    Console.ResetColor();
                }
                if (numero == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n* Insira um número diferente de 0.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                if (!vfNumero && vfDbNumero)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n* Insira apenas números inteiros!");
                    Console.ResetColor();
                    Console.WriteLine($"Ex.: 1, 5, -10, -20, 100...\n");
                }
                if (!vfNumero && !vfDbNumero)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n* Insira um número inteiro,\ne tente novamente...\n");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------\n");
            Console.ResetColor();
        }
    }
}