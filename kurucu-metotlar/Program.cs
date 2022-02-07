using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar("Seher","Elbasan",12345678,"IT");
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            calisan.Ad = "Merve";
            calisan.Soyad = "Arslan";
            calisan.No = 87456321;
            calisan.Departman = "İnsan Kaynakları";
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            Calisanlar calisanlar3 = new Calisanlar("İpek","Tunç");
            calisanlar3.CalisanBilgileri();
        }
         class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;         
        public Calisanlar(string ad, string soyad, int no, string departman)
        {
           this.Ad=ad;
           this.Soyad=soyad;
           this.No=no;
           this.Departman=departman;
        }
        public Calisanlar(){}
        public Calisanlar(string ad, string soyad)
         {
             this.Ad=ad;
             this.Soyad=soyad;
         }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}", No);
            Console.WriteLine("Çalışanın Departmanı : {0}", Departman);
        }
    }
    }
}