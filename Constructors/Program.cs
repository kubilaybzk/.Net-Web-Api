internal class Program
{
    private static void Main(string[] args)
    {
        List<Students> studentList = new List<Students>();
        studentList.Add(new Students(1, "Selam", "Naber"));
        studentList.Add(new Students(2, "Selam2", "Naber2"));
        foreach (var item in studentList)
        {
            Console.WriteLine(item._name);


        }
    }
    class Students
    {

        public string _name;
        public int _id;
        public string _adress;

        public Students(int id, string Name, string Adress)
        {
            _name = Name;
            _adress = Adress;
            _id = id;


        }


    }
}