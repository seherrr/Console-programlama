﻿using System;
using System.Collections;


namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            ArrayList liste = new ArrayList();
            try
            {
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine("{0}.sayıyı giriniz :", i);
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    liste.Add(n);

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Lüften pozitif bir sayı giriniz");

            }
            liste.Sort();
            liste.Reverse();
            ArrayList enkucuk = liste.GetRange(17, 3);
            ArrayList enbuyuk = liste.GetRange(0, 3);
            Console.WriteLine("En büyük 3 sayı : ");
            foreach (int item in enbuyuk)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("şeklinde sıralanmıştır.");

            islem.Ortalama(enbuyuk);

            Console.WriteLine("En küçük 3 sayı");
            foreach (int item in enkucuk)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("şeklinde sıralanmıştır.");

            islem.Ortalama(enkucuk);

            islem.OrtalamaToplam(enbuyuk,enkucuk);

        }
    }
    public class Islemler
    {
        public ArrayList Ortalama(ArrayList arr)
        {
            int toplam = 0;
            foreach (int item in arr)
            {
                toplam += item;
            }
            decimal ort = toplam / arr.Count;
            Console.WriteLine("Sayıların ortalaması : " + ort);
            return arr;
        }
        public ArrayList OrtalamaToplam(ArrayList arr1,ArrayList arr2)
        {
            int toplam1 = 0;
            foreach (int item in arr1)
            {
                toplam1 += item;
            }
            decimal ort1 = toplam1 / arr1.Count;
            

            int toplam2 = 0;
            foreach (int item in arr2)
            {
                toplam2 += item;
            }
            decimal ort2 = toplam2 / arr1.Count;
           
            decimal toplam_ort = ort1+ort2;
            Console.WriteLine("Sayıların ortalamasının toplaması : " + toplam_ort);
            return arr1;
            

        }
       
    }
}