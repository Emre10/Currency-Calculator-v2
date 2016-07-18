using System.IO;
using System.Xml.Serialization;

namespace Exchange
{
    public class Xml: IParse
    {
        string currencylistdata;

        public string Currencylistdata { get; set; }

        public Xml(string data)
        {
            this.currencylistdata = data;
        }

        public GetExchangeRatesResponse Parser()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GetExchangeRatesResponse));
            return (GetExchangeRatesResponse)serializer.Deserialize(new StringReader(currencylistdata));
        }
    }
}
