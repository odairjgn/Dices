using System.Collections.Generic;
using System.Linq;

namespace DicesApp.Extentions
{
    public static class FormulasExtentions
    {
        public static Dictionary<string, object> ConvertPraDicionarioObjetos(this Dictionary<string, double> dictionary)
        {
            return dictionary.ToDictionary(f => f.Key, f => (object)f.Value);
        }

        public static string ProcessarSorteioDados(this string formula)
        {
            return formula;
        }
    }
}
