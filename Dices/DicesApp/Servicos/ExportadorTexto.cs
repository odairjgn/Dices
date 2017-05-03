using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DicesApp.Servicos
{
    public class ExportadorTexto
    {
        public static void ExportarTXT<T>(ICollection<T> dados, string path)
        {
            var linhas = dados.Select(o => o.ToString());
            File.WriteAllLines(path, linhas);
        }

        public static void ExportarCSV<T>(ICollection<T> dados, string path)
        {
            var tipo = typeof(T);
            var props = tipo.GetProperties();
            var linhas = dados.Select(o => GetLineCsv(o, props));
            File.WriteAllLines(path, linhas);
        }

        private static string GetLineCsv(object o, PropertyInfo[] props)
        {
            var vls = props.Select(p => p.GetValue(o)?.ToString() ?? string.Empty);
            return string.Join(";", vls);
        }
    }
}
