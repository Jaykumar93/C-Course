namespace ClassLibrary1
{
    public class Stock
    {
        public string Symbol { get; }
        public double Price { get; set; }

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }

    }
}
