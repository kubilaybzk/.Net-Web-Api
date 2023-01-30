    using System.Collections;
using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList selam = new ArrayList();
            //Tip tanımlaması olmadan genelde Arrayler yine kullanmamız için oluşturulan ArrayListesidir.
            //Burada amacımız genel olarak 
            selam.Add("1");
            selam.Add("iki");
            selam.Add(1);

                foreach(var a in selam)
            {
                Console.WriteLine(a);
            }




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

        public Students(int id ,string Name,string Adress)
        {
           _name = Name;
            _adress = Adress;
            _id = id;


        }


    }
}
