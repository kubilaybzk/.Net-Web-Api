using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 
         Methodlar içinde generic kullanılabilir.

                Bizim ululities  diye bir sınıfımız olsun

                    Genelde sık kullandığımız işlemleri fonksiyonları bunun içinde topladığımız düşünelim.

                       

         */

        Utilities utilities = new Utilities();

        /* Bu Utilities classmızın içinde build list diye bir fonksiyonumuz olsun 
            Bu fonkisyon içine gönderdiğimiz obje yada değişkenler ile bize bir liste oluşturan bir fonksiyon oluğunu düşünelim.


            
         */

        List < string> results = utilities.BuildList<string>("Ankara", "İzmir", "İstanbul");

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        Person person1 = new Person(1, "ahmet");
        Person person2 = new Person(2, "ahmet2");
        Person person3 = new Person(3, "ahmet3");

      


        List<Person> results2 = utilities.BuildList< Person>(person1, person2, person3);

        foreach (var result in results2)
           
        {
            result.sayName();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] values)
        {
            return new List<T>(values);
        }



    }

    class Person
    {
        int _id;
        string _name;

            public Person(int id,string Name)
        {
            _id = id;
            _name = Name;
        }

          public void sayName()
        {
             Console.WriteLine(_name);
        }
    }




    /*
     Önemli kısıtlar ile beraber Generic classlar.

            şimdi biz generic olmasını istiyoruz ama sadece belirli interface değerlerden kalıtım almış classların olmasını istiyoruz

                Dışarıdan başka classların katılmmasını istemiyoruz diyelim.

     */


    //Senaryo oluşturalım

    interface IRepository<T>
    {
        List<T> getAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student
    {

    }

    //üst tarafta herhangi bir koşul belirtmedik  ve hiçbir sorun yok

    //şimdi bir koşul belirtelim. Sadece classları alsın isteyim.



    /*
        interface IRepository2<T> where T:class
        {
            List<T> getAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }
    */
    //Class iken hata almıyoruz .

    //interface IStudentDal2 : IRepository2<Student>
    //{}


    //int değer alacak diyelim şimdi ise hata alıyoruz bunun sebebi sadece class alsın dediğimiz için .

    //interface IStudentDal3 : IRepository2<int>{}

    // interface IStudentDal3 : IRepository2<string>{}

    // burada stringe kızmıyor ama biz diyoruz ki string de gelemezsin

    //Bundan dolayı şöyle bir yöntem izleyeceğiz. Class'dan sonra new() ekleyeceğiz
           //Bu şu anlama geliyor eklenen şeyler newlenebilir değişkenler olsun


    /*
            interface IRepository2<T> where T : class,new()
            {
                List<T> getAll();
                T Get(int id);
                void Add(T entity);
                void Delete(T entity);
                void Update(T entity);
            }

    */

    //interface IStudentDal3 : IRepository2<int>{}
        //Bildiğimiz gibi int değerlere kızıyordu peki string değerlere kızacak mı bakalım

    // interface IStudentDal3 : IRepository2<string>{}
        //Evet artık kızıyor.

    //Beki class olmasını istiyoruz fakat tek bir interface'e bağlı olan classlar olsun .

        //Yeni bir interface ve class oluşturalım.


    interface ITestDal
    {

    }

    class TestClass : ITestDal
    {

    }

            //Oluşturduğumuz interface kullanılsın başka interface'i kullanan değişkenler bunu kullanamasın isteyelim. 

    interface IRepository2<T> where T : class, ITestDal, new()
    {
        List<T> getAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    //  interface IStudentDal2 : IRepository2<Student>   { }   görüldüğü gibi hata veriyor.
        interface IStudentDal2 : IRepository2<TestClass> { }  //Hata vermiyor. 


    //SAdeec integer kullanmak istersek int yazmamız gerekir.










}