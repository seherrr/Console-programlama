using System;

namespace algoritma_sorulari1
{
    class soru2
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Sayı Giriniz: ");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i]%m == 0)
                    Console.WriteLine(dizi[i]+" 'M'Sayısına Tam Bölünmektedir.");
                else if (dizi[i]==m)
                {
                    Console.WriteLine(dizi[i]+" 'M' Sayısına Eşittir.");
                }
                else
                {
                    Console.WriteLine(dizi[i]+" 'M' Sayısına Tam Bölünmemektedir ve Eşit Değildir.");
                }
            }      
        }
    }
}