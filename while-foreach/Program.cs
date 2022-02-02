using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak konsolda girilen sayıya kadar(dahil) ortalama hesaplayıp konsola yazdıran program.
            Console.WriteLine("Sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam /sayi);

            //'a'dan 'z'ye kadar tüm harfleri console a yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;

            }


            Console.WriteLine("----Foreach----");
            string[] arabalar = { "aaa", "", "bbb", "ccc" };

            foreach (var araba in arabalar)
            {
               Console.WriteLine(araba);
            }


        }
    }
}