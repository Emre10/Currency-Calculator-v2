namespace Exchange
{
    public class Calculation
    {
        decimal moneyamount;
        GetExchangeRatesResponse currencylist;

        public Calculation(decimal moneyamount, GetExchangeRatesResponse moneylist)
        {
            this.moneyamount = moneyamount;
            this.currencylist = moneylist;
        }

        public string [] Calculator()
        {
            string[] calculatedresult = new string[currencylist.CurrencyPairs.Length];
            for (int i = 0; i < currencylist.CurrencyPairs.Length; i++)
            {
                string money = currencylist.CurrencyPairs[i].CounterCurrency;
                double rate = double.Parse(currencylist.CurrencyPairs[i].Rate.ToString());

                double calculate = (double)moneyamount * rate;
                calculatedresult[i] = money+" "+calculate.ToString();
            }
            return calculatedresult;
        }
    }
}
