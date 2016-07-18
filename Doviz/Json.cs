using Newtonsoft.Json;

namespace Exchange
{
    public class Json: IParse
    {
        string currencylistdata;
        public string Currencylistdata { get; set; }

        public Json(string data)
        {
            this.currencylistdata = data;
        }

        public GetExchangeRatesResponse Parser()
        {
            return (GetExchangeRatesResponse)JsonConvert.DeserializeObject(currencylistdata, typeof(GetExchangeRatesResponse));
        }
    }
}
