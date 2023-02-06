internal class Program
{
    private static void Main(string[] args)
    {
        Costumer costumer = new Costumer { Id=1,LastName="Bozak",Age=25};
        CostumerDal test = new CostumerDal();
        test.Add(costumer);

        //Şimdi veri tabanına bir kullanıcı kaydetmek istediğimizi düşünelim
        //Burada önemli bilgiler olması gerektiği ve bu ekranların eksiksiz olması gerektiğini front-end kısmında değil backen kısmında da hata almamız gerektiğini düşünelim.
        //Yukarıda bulunan örnekte isimi yollamadık ve hiçbir hata almadık şimdi şöyle bir yöntem değerlendirelim.

        Result();



    }

    class Costumer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CostumerDal
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine("{0},{1},{2},{3} added ! ", costumer.Id, costumer.FirstName, costumer.LastName, costumer.Age);
        }
    }


    //Şimdi ise burada şöyle bir yöntem değerlendirelim.
        //İsim Soyisim ve Yaş değerlerinin zorunlu olması gerektiğini ayarlayalım.
            // RequiredProperty isminde bir zorunlu alan oluşturalım .
                    // Bunun için class yapısını kullanabiliriz.



    class CostumerV2
    {
  
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CostumerDalV2
    {
        public void Add(CostumerV2 costumer)
        {
            Console.WriteLine("{0},{1},{2},{3} added ! ", costumer.Id, costumer.FirstName, costumer.LastName, costumer.Age);
        }
    }

    class RequiredProperty : Attribute
    {
        
    }


    public static void  Result()
    {
        CostumerV2 costumer2 = new CostumerV2 { Id = 1, LastName = "Bozak", Age = 25 };
        CostumerDalV2 test2 = new CostumerDalV2();
        test2.Add(costumer2);
    }


}