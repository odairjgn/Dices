using System;
using DicesApp.Extentions;
using DicesCore;
using NCalc;

namespace DicesApp.ObjetosDeValor
{
    public class Expressao
    {
        private readonly Expression _expressao;

        public Expressao(string formula)
        {
            _expressao = new Expression(formula.ProcessarSorteioDados(), EvaluateOptions.IgnoreCase);
            _expressao.Parameters = Global.Variaveis.ConvertPraDicionarioObjetos();
        }

        public bool Valida => !_expressao.HasErrors();

        public string Erro => _expressao.Error;

        public double Processar()
        {
            var obj = _expressao.Evaluate();
            return Convert.ToDouble(obj);
        }

        public bool ProcessarCalc(out string output)
        {
            var ret = !_expressao.HasErrors();

            if (ret)
            {
                var obj = _expressao.Evaluate();
                output = obj.ToString();
            }
            else
            {
                output = _expressao.Error;
            }

            return ret;
        }
        
    }
}
