/* 

Öncelikle yapmamız gereken ilk işlem projeye bu framework'u import etmek add nuget ile yapılacak.

Daha sonra bizim bu framework'e benim bir tablom var bunun karşılığı şu class diye bir şeyi bildirmemiz gerekiyor

   Buna CONTEXT denir ilerleyen aşamada bunada bakacağız.

        Şimdi burada şöyle bir işlem uygulayacağız class oluşturur gibi ETradeContext isminde bir class oluşturacağız.

            Oluşturduğumuz bu context bizim Database ismimiz ile aynı olmak zorunda.

                Config etmekle uğraşmamak için.

                    Daha sonra bu class içinde

                            public DbSet<Product> Products { get; set; }  <...> burası generic classlarımızdı hatırlayalım. ikinci Products ismi.

                                olmak üzere bir değişken import ediyoruz.

                                    Product bizim daha önce oluşturmuş olduğumuz bir class burada kullanım amacı

                                        oluşturduğumuz class değişkenleri türünde bir DbSet değerimiz var.


                     Şimdi ise From içinde bu nasıl kullanılır ona bakalım.

                        using (ETradeContext context=new ETradeContext())
                         {

                            Şeklinde bir kullanılır.
                                şimdi burada using kavramından bahsedelim.
                                    ETradeContext oldukça maliyetli bir nesne bu bellekte çok fazla yer kaplar .
                                        Burada context kısmına gittiğimiz zaman bir çok şey implement edildiğini kullanıldığını görebiliriz.
                                                Method bittiği zaman bu ETradeContext bellekten atılmaya başlanıyor ama bu using kullanılmadığı zaman
                                                    çok uzun süre alabilir buna GarbageCollection deniyor.
                                                 Biz burada bu block bittiği zaman hemen işlemi bitir daha fazla bellekte yer tutmasın demek istediğimiz için
                                                    using kullanıyoruz.


                                Şimdi bir önceki örneği ele alalım productDal içinde neler yapmıştık bi inceleyelim. ;

                                    Orada liseyi çekmek için bir sürü işlem yapmıştır hatırlayalım .


public class ProductDal{

    public DataTable GetAll(){

            SglConnection connection=new Sq1Connection(@"server=( (localdb) \mssqllocaldb;initial catalog=)
             if (connection.State==ConnectionState.Closed){
                 connection.Open();
              }

            SqlCommand command=new SqlCommand(" Select * from Products",connection);
            SqlDataReader reader=command.ExecuteReader();

            List<Product> products=new List<Product>();
            while (reader,Read())
            {
                    Product product = new Product
                    Id = =Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"),Tostring(),
                    StockAmount = Convert. ToInt32(reader[ "StockAmount"]),
                    UnitPrice = Convert. ToDecimal (reader[ "UnitPrice"]) };
                    products.Add(product);
             }
                                        I
             reader. Close();
             connection. Close();
             return products;
}


Şu koldarın ne kadar uzun sürdüğüne bakarmısınız.

    Şimdi bunun EntityFramwork ile ne kadar kısa olduğuna bakalım


        public class ProductDal
        {



            public List<Product> GetAll()
            {

                using (ETradeContext context = new ETradeContext ())
                {

                     return context. Products. ToList();
                }

            }

        }


                
                            
                      


                                            

                                                    
                


        

    

UnitOfWork tasarım deseni: Şuan yabancı ileride öğreneceğiz.



 
 */