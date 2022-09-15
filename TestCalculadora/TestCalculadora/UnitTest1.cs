using NUnit.Framework;

namespace TestCalculadora
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            int sumando1 = 2;
            int sumando2 = 3;

            int resultado = Calculadora.Suma(sumando1, sumando2);

            Assert.Equals(5, resultado);
        }
    }
}