internal class Program
{
    private static void Main(string[] args)
    {
        Costumer costumer1 = new Costumer { Id = 1,Name="Kubilay",LastName="BOZAK" };
        Costumer costumer2 = new Costumer { Id = 2, Name = "Kubilay", LastName = "BOZAK" };
        Costumer costumer3 = new Costumer { Id = 3, Name = "Kubilay", LastName = "BOZAK" };
        Costumer costumer4 = new Costumer { Address= "Address Selammm" };
        Console.WriteLine(costumer4.Address);
        Console.ReadLine();
    }



    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }

    }

    class Costumer : Person
    {
        public string Address { get; set; }

    }
}