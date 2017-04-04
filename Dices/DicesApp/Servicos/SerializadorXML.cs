using System.IO;
using System.Xml.Serialization;

namespace DicesApp.Servicos
{
    public class SerializadorXML<T>
    {
        private XmlSerializer _serializador;

        public SerializadorXML()
        {
            _serializador = new XmlSerializer(typeof(T));
        }

        public void SerializarXml(T objeto, FileInfo arquivo)
        {
            var strm = new StreamWriter(arquivo.FullName);
            _serializador.Serialize(strm, objeto);
        }

        public T Deserializar(FileInfo arquivo)
        {
            var strm = new StreamReader(arquivo.FullName);
            return (T)_serializador.Deserialize(strm);
        }
    }
}
