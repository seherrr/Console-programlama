using System;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Örnek1");
            Console.WriteLine("Lüften sayı giriniz ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }


            }
            //1 ile 100 arasındaki tek veçift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            Console.WriteLine("Örnek2");

            int tek = 0;
            int çift = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tek += i;
                }

                else
                {
                    çift += i;
                }

            }
            Console.WriteLine("Tek sayılar toplamı :" + tek);
            Console.WriteLine("Çift sayılar toplamı :" + çift);

            //break, continue
            Console.WriteLine("Örnek3");

            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Örnek4");
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}