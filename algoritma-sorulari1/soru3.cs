using System;

namespace algoritma_sorulari1
{
    class soru3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");;
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.",i+1);
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine("--Kelimelerin Tersten Yazılışı--");
            for (int i = 0; i < dizi.Length; i++)
            {
                char[] metin = dizi[i].ToCharArray();
                Array.Reverse(metin);
                string yenimetin = new string(metin);
                Console.WriteLine(yenimetin);
            }
            Console.WriteLine("--Listenin Tersten Sıralanışı--");
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }       
        }
    }
}