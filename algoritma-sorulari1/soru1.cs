using System;

namespace algoritma_sorulari1
{
    class soru1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if(sayiDizisi[i]%2 == 0)
                    Console.WriteLine("Çift Sayılar: "+sayiDizisi[i]);
            }
        }
    }
}
