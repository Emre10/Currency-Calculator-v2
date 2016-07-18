namespace Exchange
{
    public interface IParse
    {
        string Currencylistdata { get; set; }
        GetExchangeRatesResponse Parser();
    }
}



