/* İlk video

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    //Tanımlandırması class yapısına benzer genel olarak isimlendirmelerede I ile başlanır.

    interface IPerson
    {
        //kullanım amaçları temel bir nesne oluşturup bütün nesneleri ondan implemente etmektir.
        //intefaceler Soyut bir nesnedir.

        //başlangıçlarına public private eklemek gereksizdir.

        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }


    }


    class Costumer : IPerson  // bu şu anlama geliyor benim I person olarak tanımladığım herşey bunlar içinde geçerli. 
    {
        //classlar somut nesnedir.
        //Interface içinde yapılan tanımlamalar burada da eklenmelidir.
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }  // Farklı bir özellik ekleyebiliriz.

    }



    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } // Farklı bir özellik ekleyebiliriz.
    }
}

*/


/* ikinci video
internal class Program
{
    private static void Main(string[] args)
    {
        PersonManager InterFaceTest = new PersonManager();
        Costumer costumer = new Costumer { id = 1, Name = "Kubilay", LastName = "Bozak", Address = "Selam Adresim Yok" };
        Student student = new Student { id = 1, Name = "Kubilay", LastName = "Bozak", Address = "Selam Adresim Yok" };
        InterFaceTest.add(costumer); // bu şekilde hata vermezken
                                     // InterFaceTest.add(student); // bu şekilde hata veriyor sebebi ise biz aşağıda dedik ki add bir Costumer Objesi almak zorunda.


        // Bu konuyu fixlemek için biz PersonManager'içinde bulunan add fonksiyonuna sen Iperson alacaksın diyebiliriz.
        // Bu sayede Iperson olan Student Costumer Classlarının ikiisnide kullanabiliriz.
        // Methodumuza yeni bir isim koyup Add2 yazıp farkı deneyimleyeli.


        InterFaceTest.add2(student);
        InterFaceTest.add2(costumer);

        //Yukarıda görüldüğü gibi hiçbir hata almadık.


        Console.ReadLine();

    }


    //Tanımlandırması class yapısına benzer genel olarak isimlendirmelerede I ile başlanır.

    interface IPerson
    {
        //kullanım amaçları temel bir nesne oluşturup bütün nesneleri ondan implemente etmektir.
        //intefaceler Soyut bir nesnedir.

        //başlangıçlarına public private eklemek gereksizdir.

        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }


    }


    class Costumer : IPerson  // bu şu anlama geliyor benim I person olarak tanımladığım herşey bunlar içinde geçerli. 
    {
        //classlar somut nesnedir.
        //Interface içinde yapılan tanımlamalar burada da eklenmelidir.
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }  // Farklı bir özellik ekleyebiliriz.

    }



    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } // Farklı bir özellik ekleyebiliriz.
    }



    //Genelde iş katmanı sınıflarımız için Manager olarak isimlendirmeler yapılır
    //İlerleyen aşamalarda bunu daha iyi anlayacağız.
    class PersonManager
    {
        //Şimdi bir tane method tamamlayalım ve main classımızda işlemlere başlayalım

        public void add(Costumer costumer)
        {
            Console.WriteLine(costumer.Name);
        }
        public void add2(IPerson Iperson)
        {
            Console.WriteLine(Iperson.Name);
        }
    }

}
*/





using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //SecondVideo();

        ThirdVideo();
        ThirdVideoSecondPart();

        Console.ReadLine();

    }

    private static void ThirdVideoSecondPart()
    {
        ICostumerDal[] costumerDals = new ICostumerDal[2]
                {
            new SqlServerCustemerDal(),
            new OracleServerCustemerDal()
                };


        foreach (var costumerDal in costumerDals)
        {
            costumerDal.Add();
        }
    }

    private static void ThirdVideo()
    {
        CostumerManagger ctmanager = new CostumerManagger();
        ctmanager.Add(new SqlServerCustemerDal());
        ctmanager.Add(new OracleServerCustemerDal());
    }

    private static void SecondVideo()
    {
        PersonManager InterFaceTest = new PersonManager();
        Costumer costumer = new Costumer { id = 1, Name = "Kubilay", LastName = "Bozak", Address = "Selam Adresim Yok" };
        Student student = new Student { id = 1, Name = "Kubilay", LastName = "Bozak", Departmant = "Selam Adresim Yok" };
        InterFaceTest.add(costumer); // bu şekilde hata vermezken
                                     // InterFaceTest.add(student); // bu şekilde hata veriyor sebebi ise biz aşağıda dedik ki add bir Costumer Objesi almak zorunda.


        // Bu konuyu fixlemek için biz PersonManager'içinde bulunan add fonksiyonuna sen Iperson alacaksın diyebiliriz.
        // Bu sayede Iperson olan Student Costumer Classlarının ikiisnide kullanabiliriz.
        // Methodumuza yeni bir isim koyup Add2 yazıp farkı deneyimleyeli.


        InterFaceTest.add2(student);
        InterFaceTest.add2(costumer);

        //Yukarıda görüldüğü gibi hiçbir hata almadık.
    }

    interface IPerson
    {
        //kullanım amaçları temel bir nesne oluşturup bütün nesneleri ondan implemente etmektir.
        //intefaceler Soyut bir nesnedir.

        //başlangıçlarına public private eklemek gereksizdir.

        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }


    }


    class Costumer : IPerson  // bu şu anlama geliyor benim I person olarak tanımladığım herşey bunlar içinde geçerli. 
    {
        //classlar somut nesnedir.
        //Interface içinde yapılan tanımlamalar burada da eklenmelidir.
        public string Address { get; set; }  // Farklı bir özellik ekleyebiliriz.
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }



    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } // Farklı bir özellik ekleyebiliriz.
    }



    //Genelde iş katmanı sınıflarımız için Manager olarak isimlendirmeler yapılır
    //İlerleyen aşamalarda bunu daha iyi anlayacağız.
    class PersonManager
    {
        //Şimdi bir tane method tamamlayalım ve main classımızda işlemlere başlayalım

        public void add(Costumer costumer)
        {
            Console.WriteLine(costumer.Name);
        }
        public void add2(IPerson Iperson)
        {
            Console.WriteLine(Iperson.Name);
        }
    }

}


