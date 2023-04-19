using _18_Events;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Product harddist = new Product(50);
        harddist.ProductName = "Sandisk";
        Product gsm = new Product(50);
        gsm.ProductName = "Poco";
        gsm.StockControlEvent += Gsm_StockControlEvent;

        for (int i = 0; i < 10; i++)
        {

            harddist.Sell(10);
            gsm.Sell(10);
            Console.ReadLine();

        }

    }

    private static void Gsm_StockControlEvent()
    {
        Console.WriteLine("Gsm için satış sınırına yaklaşıldı.");
    }
}