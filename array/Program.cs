using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11,17 };

            Console.WriteLine("---Sırasız Dizi--");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("---Sırasız Dizisi--");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("---------Sort-------");
            Array.Clear(sayiDizisi, 3, 1);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("---------Clear--------");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("----------Reverse------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 67));

            Console.WriteLine("-----------IndexOf-------");
            Array.Resize<int>(ref sayiDizisi,8);
            sayiDizisi[7]= 13;
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            Console.WriteLine("-----------Resize-------");
            Console.WriteLine("---Resize---");
            Array.Resize<int>(ref sayiDizisi,9);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}