namespace Exchange
{
    public class Exchange
    {
        public decimal moneyvalue { get; set; }
        public string currencyname { get; set; }

        public Exchange(decimal moneyvalue, string currencyname)
        {
            this.moneyvalue = moneyvalue;
            this.currencyname = currencyname;
        }
    }
}
