internal class Program
{
    private static void Main(string[] args)
    {
        MysqlData test = new MysqlData();
        OracleData test2 = new OracleData();
        test.Add();
        test2.Add();



        Console.ReadLine();
    }




    // Bir projede override etmek için override edilecek olan fonksiyon virtual olarak oluşturulmalı.



    //Bilgi: Virtual olarak belirtilen metot yapıları kalıtım yolu ile aktarıldıkları sınıfların içerisinde
    //    override edilerek değiştirilebilirler.Eğer override işlemi uygulanmazsa üst sınıf içerisindeki yapısını koruyarak çalışmaya devam eder.

    class Database
    {
        public virtual  void Add()
        {
            Console.WriteLine("Database Added");
        }
        public void Delete()
        {
            Console.WriteLine("Database Deleted");
        }
    }

    class MysqlData : Database
    {
       public override void Add()
        {
            Console.WriteLine("Mysql Added");
            base.Add(); // Burası override edilen fonksiyonun tekrar kullanılmasını sa
        }
    }

    class OracleData : Database
    {
        
    }
}