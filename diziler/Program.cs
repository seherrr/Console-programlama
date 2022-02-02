using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = { "Kuş", "Böcek", "Aslan", "Ayı", "Fil", "Maymun" };
            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[3]);
            Console.WriteLine(dizi[0]);

            Console.WriteLine("---döngülerle dizi kullanımı---");      
           //kalvyeden girilen n tane sayıının ortalamasını hesaplayan program.     
           Console.Write("Eleman sayısı giriniz");
           int diziUzunlugu = int.Parse(Console.ReadLine());
           int[] sayiDizisi = new int[diziUzunlugu];
           int toplam = 0;
           
           for (int i = 0; i < diziUzunlugu; i++)
           {
               Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
               sayiDizisi[i] = int.Parse(Console.ReadLine());
               
           }
           foreach (var sayi in sayiDizisi)
           {
               toplam+=sayi;
           }
            Console.WriteLine("ortalama:"+toplam/diziUzunlugu);

        }
    }
}