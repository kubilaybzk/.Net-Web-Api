using _11_HandleException_HataYönetimi;


internal class Program
{
    private static void Main(string[] args)
    {
        //Şimdi şöyle bir mantık geliştirleim.

        //HataMesajıAlalım();

        //HataMesajimiz();

        //OrtaSegmentError();









        
        //Şimdi elimizde böyle bir fonksiyon olsun.
        //Biz burda kendi hata mesajımızı göndermek isteyelim.

        //Burayı backend gibi düşünelim ve burada bir fonksiyon oluşturarak
        //veri tabanından veri geldiğini ve gelen verilere göre sonuç gönderen bir api olduğunu düşünelim.
         static void find()
        {

            List<string> studentList = new List<string>();

            studentList.Add("Ali");
            studentList.Add("Ahmet");
            studentList.Add("Mehmet");


            if (!studentList.Contains("Ahmets"))
            {
                throw new RecordNotFoundException (  "Selam" );
            }
            else
            {
                Console.WriteLine("Bulundu");
            }
        }



        //Burasıda front-end tarafımız olsun ve burada şöyle bir yöntem ile çalışalım.

        try
        {
            find();
        }
        catch(RecordNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }




    }




    class Students
    {

        public string _name;
        public int _id;
        public string _adress;

        public Students(int id, string Name, string Adress)
        {
            _name = Name;
            _adress = Adress;
            _id = id;


        }


    }

    private static void OrtaSegmentError()
    {
        string[] student = new string[3] { "Selam", "Naber", "Nasilsin" };
        foreach (var item in student)
        {
            Console.WriteLine(item);
        }


        // Şimdi orta segment prof. bir Hata mesajı alalım .
        try
        {
            student[3] = "Hataya düşsün diye";
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void HataMesajimiz()
    {
        string[] student = new string[3] { "Selam", "Naber", "Nasilsin" };
        foreach (var item in student)
        {
            Console.WriteLine(item);
        }


        // Şimdi Hata mesajı alalım .
        try
        {
            student[3] = "Hataya düşsün diye";
        }
        catch
        {
            Console.WriteLine("Hata");
        }
    }

    private static void HataMesajıAlalım()
    {
        string[] student = new string[3] { "Selam", "Naber", "Nasilsin" };
        foreach (var item in student)
        {
            Console.WriteLine(item);
        }

        student[3] = "Hataya düşsün diye";
    }


    


}