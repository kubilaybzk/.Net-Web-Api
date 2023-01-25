using System;
namespace Interfaces
{
	interface ICostumerDal //Buradaki Dal Data Acces layer olarak adlandırılır crud işlemleri bu şekilde isimlendirme tercih edilir.
	{
		void Add();
		void Update();
		void Delete();

	}




	class SqlServerCustemerDal:ICostumerDal
	{
        public void Add()
		{
            Console.WriteLine(" SqlServerCustemerDal Add");

        }
        public void Update()
        {
            Console.WriteLine("SqlServerCustemerDal Update");

        }
        public void Delete()
        {
            Console.WriteLine("SqlServerCustemerDal Delete");

        }
    }




    class OracleServerCustemerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("OracleServerCustemerDal Add");

        }
        public void Update()
        {
            Console.WriteLine("OracleServerCustemerDal Update");

        }
        public void Delete()
        {
            Console.WriteLine("OracleServerCustemerDal Delete");

        }
    }



     class CostumerManagger
    {
        public  void Add(ICostumerDal costumerDal)
        {
            //şimdi söyle bir mantık düşünelim.
            //bir Sql'e bağlı olarak bir Add methodu geliştirdik.
            //Başka bir müşteri ben oracle kullanmak istiyorum dedi o zaman ne olacak;
            //Bu Add methodunu baştan yazmamız gerekecek.
            //Biz bunu istemiyoruz bizim projemiz her ikisinide desteklesin isteyelim.
            //Add methoduna biz ikiside gelebilir şeklinde tasarlamamız gerekiyor bunun için yapmamız gereken yöntem şu
            //Burada şöyle bir yöntem geliştireceğiz.
            // Sql eklemek için Interface'e bağlı olan değerleri girelim ki içeriye isteğe göre göndermeler yapabilelim.
            costumerDal.Add();


            /* 
             
             Şimdi burada söyle bir geliştirme planladık.

                    CostumerManagger ctmanager = new CostumerManagger();

            yazarak biz bu classımızı oluşturduk.

                    Daha sonra ;

                          ctmanager.Add(new SqlServerCustemerDal());
                          ctmanager.Add(new OracleServerCustemerDal());,

                    Şeklinde iki database içine bilgilerimizi yazabildik.


            Eğer;
                public  void Add(OracleServerCustemerDal OrserverCustemerDal){ ...}

                şeklinde bir tanımlama yapmış olsaydık burada söyle bir sıkıntı yaşardık.

                OrserverCustemerDal.Add(new SqlServerCustemerDal());  // Bu satırı çalıştıramazdık hata alırdık.
                OrserverCustemerDal.Add(new OracleServerCustemerDal()); // Bu satırı başarı ile çalıştırabilirdik hata almazdık.,

            Yani projemiz tek yönlü çalışırdı.



             */
        }
    }



}

