using Divisor;
using Xunit;

namespace Divisot.Test
{
    public class DivisorTest
    {
        [Fact]
        public void Resultado_Divisor()
        {
            var divisor = new Divisores();
            var resultado = divisor.Operacao(45);
            Assert.Equal("1 3 5 9 15 45", resultado);
        }


        [Fact]
        public void Resultado_Primo()
        {
            var divisor = new Primos();
            var resultado = divisor.Operacao(45);
            Assert.Equal("2 3 5 7 11 13 17 19 23 29 31 37 41 43", resultado);
        }


    }
}
