using Newtonsoft.Json;

namespace Exchange
{
    public class Json: IParse
    {
        string data;
        public string Data { get; set; }

        public Json(string data)
        {
            this.data = data;
        }

        public GetExchangeRatesResponse Parser()
        {
            return (GetExchangeRatesResponse)JsonConvert.DeserializeObject(data, typeof(GetExchangeRatesResponse));
        }
    }
}
