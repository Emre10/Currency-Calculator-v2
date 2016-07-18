using System.IO;
using System.Xml.Serialization;

namespace Exchange
{
    public class Xml: IParse
    {
        string data;

        public string Data { get; set; }

        public Xml(string data)
        {
            this.data = data;
        }

        public GetExchangeRatesResponse Parser()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GetExchangeRatesResponse));
            return (GetExchangeRatesResponse)serializer.Deserialize(new StringReader(data));
        }
    }
}
