using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange(500, "USD");
            Data data = new Data(exchange.currencyname, "application/json"); //text/xml
            //Xml xml = new Xml(data.GetData());
            Json json = new Json(data.GetData());
            GetExchangeRatesResponse comingdata = json.Parser(); // Xml.Parser();
            Calculation calculate = new Calculation(exchange.moneyvalue, comingdata);
            Print.WriteScreen(calculate.Calculator());
            Console.ReadLine();
        }
    }
}
