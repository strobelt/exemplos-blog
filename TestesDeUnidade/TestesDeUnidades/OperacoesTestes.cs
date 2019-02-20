using Calculadora;
using NUnit.Framework;

namespace TestesDeUnidade
{
    [TestFixture]
    public class OperacoesTestes
    {
        [Test]
        public void SomarDeveRetornarASomaCorretaDeDoisNumeros()
        {
            Operacoes operacoes = new Operacoes();
            var resultado = operacoes.Somar(1, 2);

            Assert.AreEqual(resultado, 3);
        }
    }
}
