using Divisor.Utilitarios;
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

            if (Regex.IsMatch(valor, @"^[0-9]+$") || Convert.ToInt64(valor) < 0)
            {
                var task = TaskUtil.CreateResilient(() => Executar(valor));
                task
                    .ContinueWith((e) =>
                    {
                        if (e.IsFaulted)
                            Console.WriteLine("Ops. Exceção: " + e.Exception.Message);
                        else
                            Console.WriteLine("Fim!");
                    });

                task.Start();
            }
            else
            {
                Console.WriteLine("O Campo digitado não é válido");
            }
            Console.ReadKey();
        }

        static void Executar(string valor)
        {
            var divisores = new Divisores();
            Console.WriteLine("Números divisores: " + divisores.Operacao(Convert.ToInt64(valor)));

            var primos = new Primos();
            Console.WriteLine("Números primos: " + primos.Operacao(Convert.ToInt64(valor)));
        }
    }
}
