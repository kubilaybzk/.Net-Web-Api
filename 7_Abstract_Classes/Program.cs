internal class Program
{
    private static void Main(string[] args)
    {



        /*
          Abstrack classların cağrılma şekli normal classlara göre biraz daha farklı.

                    Database test = new Database();
           Bu şekilde bir kullanma malesef çalışmıyor çünkü biz normal bir class yapmadık abstrack bir class oluşturdul.

                    Dat

        */

        Database test = new OracleServer();
        test.Delete();
        Console.ReadLine();
    }


    abstract class Database
    {



        //Söyle bir kurgumuz olsun bir ürünü veri tabanına eklediğimizi düşünelim.
            //Ekleme için 3 farklı Tablomuz var.
            //Her tablo için ekleme değerimiz birebir aynı.
            //Her tablo için silme fonksiyonumuz farklı.


        public void add() { Console.WriteLine("Added by defauld."); }
        public abstract void Delete();



    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by SqlServer.");
        }

    }
    class   OracleServer : Database
    {
        public override void Delete()
        {

            Console.WriteLine("Added by OracleServer.");
        }

    }

    class MySqlServer : Database
    {
        public override void Delete()
        {}

    }

    //Şimdi tanımlamaları yaptık main içinde kullanımına bakalım.



}




/* 
 
 Tamamen bir class'tır interface gibi değildir.
Bunun interfaceler ile virtual methodların birleşimi gibi düşünebiliriz.
    Tamamen kalıtım amacı ile kullanılır.


    Aslında abstrack methodlar içi dolu olmayan methodlar diyebiliriz.


 
 
 
 */