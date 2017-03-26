using DicesApp.Extentions;
using NCalc;

namespace DicesApp.ObjetosDeValor
{
    public class Formula
    {
        private readonly Expression _expressao;

        public Formula(string formula)
        {
            _expressao = new Expression(formula.ProcessarSorteioDados(), EvaluateOptions.IgnoreCase);
            _expressao.Parameters = Global.Variaveis.ConvertPraDicionarioObjetos();
        }

        public bool Valida => !_expressao.HasErrors();

        public string Erro => _expressao.Error;

        public double Processar()
        {
            return (double) _expressao.Evaluate();
        }
    }
}
