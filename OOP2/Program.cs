using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "12345678978";

            //Kodlama.İo

            TüzelMüsteri musteri2 = new TüzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12456";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "12365478956";


            Müsteri musteri3 = new GercekMüsteri();
            Müsteri musteri4 = new TüzelMüsteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

           
        }
    }
}
