internal class Program
{
    private static void Main(string[] args)
    {
        Costumer costumer = new Costumer { Id=1,LastName="Bozak",Age=25};
        CostumerDal test = new CostumerDal();
        test.Add(costumer);
    }

    class Costumer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }



    class CostumerDal
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine("{0},{1},{2},{3} added ! ", costumer.Id, costumer.FirstName, costumer.LastName, costumer.Age);
        }
    }
}