using System;
using System.Threading;
using System.Threading.Tasks;

namespace Divisor.Utilitarios
{
    public static class TaskUtil
    {
        private static int numTentativas = 3;
        private static int tempoIntervalo = 5;

        public static Task CreateResilient(Action action)
        {
            return new Task(() =>
            {
                while (true)
                {
                    try
                    {
                        action();
                        break;
                    }
                    catch
                    {
                        numTentativas--;
                        if (numTentativas <= 0)
                            throw;

                        Thread.Sleep(tempoIntervalo);
                    }
                }
            });
        }
    }
}
