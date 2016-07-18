using Exchange;
using NUnit.Framework;

namespace ExchangeTest
{
    [TestFixture]
    public class XmlTest
    {
        [Test]
        public void Parser()
        {
            string testdata = "<GetExchangeRatesResponse xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><CurrencyPairs><CurrencyPair><BaseCurrency>USD</BaseCurrency><CounterCurrency>USD</CounterCurrency><Rate>1</Rate></CurrencyPair></CurrencyPairs></GetExchangeRatesResponse>";
            Xml xml = new Xml(testdata);
            GetExchangeRatesResponse response = xml.Parser();

            Assert.AreEqual("USD", response.CurrencyPairs[0].BaseCurrency);
            Assert.AreEqual("USD", response.CurrencyPairs[0].CounterCurrency);
            Assert.AreEqual(1, response.CurrencyPairs[0].Rate);
        }
    }
}
