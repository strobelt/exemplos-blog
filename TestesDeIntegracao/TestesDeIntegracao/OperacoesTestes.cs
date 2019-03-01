using Calculadora;
using NUnit.Framework;

namespace TestesDeIntegracao
{
    [TestFixture]
    public class OperacoesTestes
    {
        private Operacoes operacoes;

        [SetUp]
        public void SetUp()
        {
            operacoes = new Operacoes(new Persistencia());
        }

        [Test]
        public void SalvarDeveGuardarResultadoNoBancoDeDados()
        {
            var resultado = 10;

            var resultadoId = operacoes.Salvar(resultado);

            var resultadoNoBanco = BuscarNoBancoDeDados(resultadoId);
            Assert.AreEqual(resultadoNoBanco, resultado);
        }

        private double BuscarNoBancoDeDados(int resultadoId)
        {
            // Logica de busca no Banco de Dados
        }
    }
}




















