internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    /* 
     Şimdi şöyle bir senaryo düşünelim ekleme silme ve düzenleme bütün  veya tek ürünleri
    getiren bir class ve interface yazmak isteyelim

        Ne yapmamız gerekir öncelikle bir interface oluşturmak isteriz.
        Daha sonra

    */

    interface IProductDal
    {
        List<Product> getAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }

   

    class Product{}


    /*
    Aynı işlemleri kişiler için yapmak isteyelim.
     */

    interface ICostumerDal
    {
        List<Product> getAll();
        Product Get(int id);
        void Add(Costumer costumer);
        void Delete(Costumer costumer);
        void Update(Costumer costumer);
    }

    class Costumer { }
    /*
    Gördüğümüz gibi aynı işlemlere sahip fakat isimlerini değiştirmemiz gerekti.
            İşte bu gibi durumlarda şöyle bir şey düşünebiliriz
                Yapılar çok benzer ve içerikler değişiyor işte bu problemi generic yapılar ile çözeriz.
                   Generik bir yapıyı belli etmek için <T> olarak bir değişken classların veya interfaces lerin tiplerini belirtiriz.

      */

        interface IRepository<T>
            {
                List<T> getAll();
                T Get(int id);
                void Add(T entity);
                void Delete(T entity);
                void Update(T entity);
            }


    /*
    Şimdi burada oluşturduğumuz yeni yapımıza göre şöyle bir interface düzenlemesi yapalım.
        İsimler karışmasın diye V2 olarak adlandıralım.
    */

    interface IProductDalV2 : IRepository<ProductV2>
    {

    }

    interface ICostumerDalV2 : IRepository<CostumerV2>
    {

    }

    /*
    Şimdi iki adet Class Ekleyelim ve İmplemet ederek sonuçları görelim.
    */

    class ProductV2 : IProductDalV2
    {
        public void Add(ProductV2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductV2 entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductV2> getAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductV2 entity)
        {
            throw new NotImplementedException();
        }

        ProductV2 IRepository<ProductV2>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    class CostumerV2 : ICostumerDalV2
    {
        public void Add(CostumerV2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CostumerV2 entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CostumerV2> getAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CostumerV2 entity)
        {
            throw new NotImplementedException();
        }

        CostumerV2 IRepository<CostumerV2>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    /*
    Gördüğümüz gibi kodlarda bulunan karmaşıklığı fazlalığı burada kaldırdık.
        Bu sayede daha temiz bir interface elde etmiş olduk.
    */








}