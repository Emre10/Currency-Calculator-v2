namespace Exchange
{
    public interface IParse
    {
        string Data { get; set; }
        GetExchangeRatesResponse Parser();
    }
}
