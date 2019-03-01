namespace Calculadora
{
    public class Operacoes
    {
        private readonly Persistencia _persistencia;

        public Operacoes(Persistencia persistencia)
        {
            _persistencia = persistencia;
        }

        public int Salvar(double resultado)
        {
            return _persistencia.SalvarNoBancoDeDados(resultado);
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
