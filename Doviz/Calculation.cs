namespace Exchange
{
    public class Calculation
    {
        decimal moneyvalue;
        GetExchangeRatesResponse moneylist;

        public Calculation(decimal moneyvalue, GetExchangeRatesResponse moneylist)
        {
            this.moneyvalue = moneyvalue;
            this.moneylist = moneylist;
        }

        public string [] Calculator()
        {
            string[] calcresult = new string[moneylist.CurrencyPairs.Length];
            for (int i = 0; i < moneylist.CurrencyPairs.Length; i++)
            {
                string money = moneylist.CurrencyPairs[i].CounterCurrency;
                double rate = double.Parse(moneylist.CurrencyPairs[i].Rate.ToString());

                double calculate = (double)moneyvalue * rate;
                calcresult[i] = money+" "+calculate.ToString();
            }
            return calcresult;
        }
    }
}
