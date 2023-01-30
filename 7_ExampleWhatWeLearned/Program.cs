internal class Program
{
    private static void Main(string[] args)
    {
        //Şimdi burada amacımız kullanıcının fikrine göre VeriTabanında yada Dosya sisteminde bir geliştirme yapmak.
       //Bundan dolayı şimdi yapmamız gereken işlem Tek satırda değişiklik yaparak işlemlerimizi halletmemiz gerekiyor.
       //Bunun için 9. satırda bulunan DatabaseLogger satırını değiştirmemiz yeterli oluyor .

        CostumerManager cmanager = new CostumerManager();
        cmanager.Logger = new DatabaseLogger();
        
        cmanager.Add();
        Console.ReadLine();
    }



    /*
     
     Şimdi şöyle bir durum düşünelim bizim bir projemiz var biz bu projede her zaman bir add methodu uyguladığımızda bunu loglamak isteyelim.
            Bir müşterimiz Database içine
            Bir müşterimiz ise txt dosyası içine loglansın istiyor.
            Ne yapmamız gerekiyor onu planlayalım.
            
     
     */


    class CostumerManager
    {

        public Ilogger Logger { get; set; };

        public void Add()
        {
            Logger.Log();
            
            Console.WriteLine("Added");
        }

        //Normal şartlarda logları böyle düşürmek istemiyoruz.
        //İsteğimiz şu şekilde biz bir 
    }


    interface Ilogger
    {
        void Log();
    }


    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("DatabaseLogger Added");
        }
    }

    class TextLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("TextLogger Added");
        }
    }





}

