internal class Program
{

    public delegate void MyDelagate(string Selam);
    private static void Main(string[] args)
    {
        CustomerManager manager = new CustomerManager();
        //manager.SendMessage();
        //manager.ShowAlert();

        //Şimdi dalaget kullanarak buna bakalım.
        MyDelagate test = manager.SelamVer;
        test += manager.ShowAlert;
        //ekrana hiçbir şey yazmadı bunun sebebi tamam sen buna delegate et ama çalıştır demedik sadece eşlik et dedik.
        test("Naber nasılsın");


        Console.WriteLine();
    }

    public  class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Danger !! ");
        }
        public void SelamVer(string Selam)
        {
            Console.WriteLine(Selam);
        }
    }
}