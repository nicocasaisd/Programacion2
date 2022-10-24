using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calc = Calculadora.Calculadora;

namespace TestCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CalcularSuma()
        {
            // Arrange: Inicializar las variables
            int sumando1 = 2;
            int sumando2 = 3;

            // Act: llamar al metodo a testear
            int resultado = calc.Suma(sumando1, sumando2);

            // Assert: comprobar el valor con el esperado
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_CalcularDivision()
        {
            // Arrange: Inicializar las variables
            int dividendo = 120;
            int divisor = 0;

            // Act: llama al metodo a testear
            double resultado = calc.Division(dividendo, divisor);
        }
    }
}
