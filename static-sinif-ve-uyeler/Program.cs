using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Seher", "Elbasan", "IT");
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("İpek", "Tunç", "İnsan Kaynakları");
            Calisan calisan3 = new Calisan("Mert", "Yılmaz", "Servis");
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            
            Console.WriteLine("Toplama İşlemi : {0}", Islemler.Topla(100,500));
            Console.WriteLine("Çıkarma İşlemi : {0}", Islemler.Cikar(600,300));
        }
    }
    class Calisan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
      public static long Topla(int sayi1,int sayi2)
      {
          return sayi1+sayi2;
      }
       public static long Cikar(int sayi1,int sayi2)
      {
          return sayi1-sayi2;
      }

    }
}
