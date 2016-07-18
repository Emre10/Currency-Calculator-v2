using Exchange;
using NUnit.Framework;

namespace ExchangeTest
{
    [TestFixture]
    public class JsonTest
    {
        [Test]
        public void Parser()
        {
            string testdata = "{\"currencyPairs\": [{\"baseCurrency\": \"USD\",\"counterCurrency\": \"USD\",\"rate\": 1}]}";
            Json json = new Json(testdata);
            GetExchangeRatesResponse response = json.Parser();

            Assert.AreEqual("USD", response.CurrencyPairs[0].BaseCurrency);
            Assert.AreEqual("USD", response.CurrencyPairs[0].CounterCurrency);
            Assert.AreEqual(1, response.CurrencyPairs[0].Rate);
        }
    }
}
