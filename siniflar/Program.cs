using System;

namespace siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar();
            calisan.Ad = "Seher";
            calisan.Soyad = "Elbasan";
            calisan.No = 12345678;
            calisan.Departman = "IT";
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            calisan.Ad = "Merve";
            calisan.Soyad = "Arslan";
            calisan.No = 87456321;
            calisan.Departman = "İnsan Kaynakları";
            calisan.CalisanBilgileri();
        }
    }
    class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}", No);
            Console.WriteLine("Çalışanın Departmanı : {0}", Departman);

        }



    }
}
