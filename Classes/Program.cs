
using Classes; //Bu import edilmek zorunda dışarıdan class kullanmak istediğimiz için.


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myperson = new Person();
            myperson.addPerson();
            myperson.update();
            Costumer test = new Costumer();
            Console.WriteLine(test.City);
            Costumer test2 = new Costumer(1,"Kubilay","Bozak","İstanbul");
            Console.WriteLine(test2.Name);


        }
            
    }
    //Bir class oluşturalım.
    //class Person
    //{
    //    public void addPerson()
    //    {
    //        Console.WriteLine("Costumer Added.");
    //    }

    //    public void update()
    //    {
    //        Console.WriteLine("Costumer updated");

    //    }
    //}

    // Şimdi bu class'ı başka bir dosya içine taşıyalım projenin içinde bir class oluşturmak için sağ tık add addClass seçeneğine tıklayayıp class ekleyelim.
}
















