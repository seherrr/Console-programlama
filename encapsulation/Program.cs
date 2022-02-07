using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Seher";
            ogrenci.Soyisim = "Elbasan";
            ogrenci.OgrenciNo = 12345678;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileri();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileri();

            Ogrenci ogrenci2 = new Ogrenci("Merve","Arslan",8745632,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileri();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az bir olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("*********Öğrenci Bilgileri********");
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}
