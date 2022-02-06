using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("İpek");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisinde verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //addrange
            Console.WriteLine("*****Add Range*****");
            string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            liste.Sort(); //Bütün elemanların aynı değişken türünde olması gerekir.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.BinarySearch(9); //Sort işleminden sonra kullanılır.
            liste.Reverse(); // Listeyi ters sıralar
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            liste.Clear(); // Bütün listeyi siler.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}
