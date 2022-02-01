using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //atama ve işlemli atama
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mnatıksal Operatörler
            
            bool isSucces=true;
            bool isCompleted=false;

            if(isSucces && isCompleted)
                Console.WriteLine("perfect");

            if(isSucces || isCompleted)
                Console.WriteLine("great");

            if(isSucces && !isCompleted)
                Console.WriteLine("fine");
                */

            //İlişkisel Operatörler

            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);
            

            /*
            //Aritmetik Operatörler

            int s1=10;
            int s2=5;
            int sonuc=s1/s2;
            Console.WriteLine(sonuc);
            sonuc=s1*s2;
            Console.WriteLine(sonuc);
            sonuc=s1+s2;
            Console.WriteLine(sonuc);
            sonuc=s1++;
            Console.WriteLine(sonuc);

            //%:mod
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
            */

            //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
            //Mantıksal Operatörler (||, &&, !)
            //İlişkisel Operatörler (==,!=, <, >, >=,<=)
            //Aritmetik (+, -, *, /, %, ++, --)
        }
    }
}
