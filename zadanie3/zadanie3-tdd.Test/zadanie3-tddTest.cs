using System;
using Xunit;

namespace zadanie3_tdd.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMetody()
        {
            int oczekiwanyWynik = 10;

            var wynik = klasa.metoda();

            Assert.Equal(oczekiwanyWynik, wynik);
        }
    }
}
