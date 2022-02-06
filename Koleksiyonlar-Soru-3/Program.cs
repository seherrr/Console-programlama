using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            Console.Write("Bir cümle giriniz: ");
            string metin=Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i=0;i<metin.Length;i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                }

            }

            Console.WriteLine("Kelime içerisinde toplam " + sayac + " tane sesli harf var.");
            Console.WriteLine("Bu sesli harfler:");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
