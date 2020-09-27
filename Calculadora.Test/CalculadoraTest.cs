using NUnit.Framework;

namespace Calculadora.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        private CalculadoraSimples _calculadora;

        //Aqui podemos instanciar nossas classes, sem precisar instancia em cada metodo
        [SetUp]
        public void Setup()
        {
            _calculadora = new CalculadoraSimples();
        }

        //metodo marcado dentro de uma clase com [TestFixture] 
        [Test]
        public void DeveSomarDoisNumeros()
        {
            var resultado = _calculadora.Adicionar(5, 5);
            Assert.AreEqual(10, resultado);
        }

        [Test]
        [TestCase(5, 11)]
        public void MultiplicacaoMaiorQue50(int num1, int num2)
        {
            var resultado = _calculadora.Multiplicar(num1, num2);
            Assert.IsTrue(resultado);
        }
    }
}