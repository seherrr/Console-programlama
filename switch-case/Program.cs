using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("OCAK");
                    break;
                case 2:
                    Console.WriteLine("ŞUBAT");
                    break;
                 case 3:
                    Console.WriteLine("MART");
                    break;
                case 4:
                    Console.WriteLine("NİSAN");
                    break; 
                default:
                    Console.WriteLine("Yanlış veri girişi!");
                    break;
            }    

            switch (month)
            {
                
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("KIŞ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İLKBAHAR");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("YAZ");
                    break;
                default:
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("SONBAHAR");
                    break;
            }                
        }
    }
}
