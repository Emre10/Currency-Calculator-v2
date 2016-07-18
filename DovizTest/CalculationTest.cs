using NUnit.Framework;
using Exchange;

namespace ExchangeTest
{
    [TestFixture]
    public class CalculationTest
    {
        [Test]
        public void Calculator()
        {
            CurrencyPair[] testdata = new CurrencyPair[1];
            CurrencyPair data = new CurrencyPair();
            data.BaseCurrency = "USD";
            data.CounterCurrency = "USD";
            data.Rate = 1;
            testdata[0] = data;

            GetExchangeRatesResponse testlist = new GetExchangeRatesResponse();
            testlist.CurrencyPairs = testdata;

            Calculation testcalculate = new Calculation(10, testlist);

            string[] comingdata = testcalculate.Calculator();

            Assert.AreEqual(comingdata[0],"USD 10");
        }
    }
}
