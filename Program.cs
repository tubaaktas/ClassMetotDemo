using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {//musterilerin ozelliklerini tanimla id, ad, soyad
            Musteri musteri1 = new Musteri();

            musteri1.Id = "0000001";
            
            musteri1.MusterininAdi = "Tugba";
            
            musteri1.MusterininSoyadi = "Aktas";
            
            Musteri musteri2 = new Musteri();
            
            musteri2.Id = "0000002";
            
            musteri2.MusterininAdi = "Tolgay ";
            
            musteri2.MusterininSoyadi = "Gedik";
            
            Musteri musteri3 = new Musteri();
            
            musteri3.Id = "0000003";
            
            musteri3.MusterininAdi = "Zeyt";
            
            musteri3.MusterininSoyadi = "Nil";





            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();

            Console.WriteLine("Bankamıza hoşgeldiniz1");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz" + "\n" +
                "0-çıkış" + "\n" +
                " 1-ekle" + "\n" +
                " 2-sil " + "\n" +
                " 3-listele ");




            while (true)
            {
                Console.WriteLine("Seçiminizi giriniz: ");
                int secim = Convert.ToInt16(Console.ReadLine());

                switch (secim)
                {
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor!");
                        break;
                    case 1:
                        musteri.Ekle(musteri1);
                        musteri.Ekle(musteri2);
                        musteri.Ekle(musteri3);
                        break;
                    case 2:
                        musteri.Sil(musteri1);
                        musteri.Sil(musteri2);
                        musteri.Sil(musteri3);
                        break;
                    case 3:
                        musteri.Listele(musteriler);
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                        break;
                }

            }

        }
    }
}