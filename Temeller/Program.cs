// See https://aka.ms/new-console-template for more information



namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(2,3);
            Add3(5,12);
            Add4(1,2,3,4,5);

        }
        //Veri almadan  yazılan fonksiyonlar 
        static void Add()
        {
            Console.WriteLine("Added");
        }
        //Veri Alınarak yazılan fonksiyonlar 
        static void Add2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }
        //Default değerlere sahip ve veri Alınarak yazılan fonksiyonlar
        //Default değerler her zaman en sona yazılması gerekir. Yoksa hata verir uygulama .
        static void Add3(int number1, int number2=20)
        {
            Console.WriteLine(number1 + number2);
        }
        //Methodun kaç parametresi var bilmiyorsak yapmamız gerken işlem.
        static void Add4(int number1,int number2, params int[] numbers)
        {
            Console.WriteLine(number1 + number2 + numbers.Sum()) ;
        }

    }
}


//Statik: => Method