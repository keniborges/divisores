using Divisor.Factory;
using System;

namespace Divisor
{
    public class Divisores : IDivisor
    {
        public string Operacao(long valor)
        {
            var retorno = string.Empty;
            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                    retorno += " " + Convert.ToString(i);
            }
            return retorno;
        }
    }
}
