using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir 

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Turuncu");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //foreach ve ListForeach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(1);
            renkListesi.Remove("Mavi");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //liste içerisinde arama
            if (sayiListesi.Contains(3))
                Console.WriteLine("Listede vardır.");

            //eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //diziyi list'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();

            kullanici1.Isim = "İpek";
            kullanici1.Soyad = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();

            kullanici2.Isim = "Erhan";
            kullanici2.Soyad = "Büyük";
            kullanici2.Yas = 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);


            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Tuna",
                Soyad = "Tunç",
                Yas = 22

            });

              foreach (var item in kullaniciListesi)
              {
                  Console.WriteLine("Kullanıcı Bilgileri");
                  Console.WriteLine(item.Isim);
                  Console.WriteLine(item.Soyad);
                  Console.WriteLine(item.Yas);
              }
              foreach (var item in yeniListe)
              {
                  Console.WriteLine(item.Isim);
                  Console.WriteLine(item.Soyad);
                  Console.WriteLine(item.Yas);
              }
               
                

        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyad;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
        }