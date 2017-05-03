using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DicesApp.Servicos
{
    public class SerializadorJson
    {
        public static void SerializarJson<T>(T valor, FileInfo path)
        {
            var json = JsonConvert.SerializeObject(valor);
            File.WriteAllText(path.FullName, json, Encoding.UTF8);
        }

        public static T DeserializarJson<T>(FileInfo path)
        {
            var json = File.ReadAllText(path.FullName, Encoding.UTF8);
            var obj = JsonConvert.DeserializeObject(json, typeof(T));

            return (T) obj;
        }
    }
}
