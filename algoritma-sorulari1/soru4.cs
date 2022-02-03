using System;

namespace algoritma_sorulari1
{
    class soru4
    {
        static void Main(string[] args)
        {    
            
            Console.WriteLine("Lüften bir cümle yazınız : ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            int sayi = 0;
            Console.WriteLine("Toplam kelime sayısı :" + kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfler = kelimeler[i].ToCharArray();
                sayi += harfler.Length;
            }
            Console.WriteLine("Toplam harf sayısı :" + sayi);

        }
    }
}