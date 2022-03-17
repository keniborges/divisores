using System;
using System.Text.RegularExpressions;

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor : ");
            string valor = Console.ReadLine();
            if(Regex.IsMatch(valor, @"^[0-9]+$") || Convert.ToInt64(valor) < 0)
            {
                var divisores = new Divisores();
                Console.WriteLine("Números divisores: " + divisores.Operacao(Convert.ToInt64(valor)));

                var primos = new Primos();
                Console.WriteLine("Números primos: " + primos.Operacao(Convert.ToInt64(valor)));
            }
            else
            {
                Console.WriteLine("O Campo digitado não é válido");
            }
            Console.ReadKey();

        }
    }
}
