using System.Net;

namespace Exchange
{
    class Data
    {
        string currencytype, resulttype;
        public string Currencytype { get; set; }
        public string Resulttype { get; set; }

        public Data(string type, string resulttype)
        {
            this.currencytype = type;
            this.resulttype = resulttype;
        }

        public string GetData()
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=" + currencytype + "&access_token=" + token;
            string result;

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", resulttype);
                result = webClient.DownloadString(apiurl);
            }

            return result;
        }
    }
}
