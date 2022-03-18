using Divisor.Factory;
using System;

namespace Divisor
{
    public class Primos : IDivisor
    {
        public string Operacao(long valor)
        {
            var retorno = string.Empty;
            for (long i = 1; i <= valor; i++ )
            {
                int qtd = 1;
                for (int interno = 2; interno <= i; interno++)
                {
                    if ((i % interno) == 0)
                        qtd++;
                    if (qtd > 2)
                        break;
                }
                if(qtd == 2)
                    retorno += Convert.ToString(i) + " ";
            }
            return retorno.TrimEnd();
        }
    }
}
