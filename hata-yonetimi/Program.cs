using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try{
                Console.WriteLine("bir sayı giriniz:");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayı: "+sayi);
            }
            catch(Exception ex){
                Console.WriteLine("hata: "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("işlem tamamlandı.");
            }
            */

            try
            {
                //int a=int.Parse(null);
                //int a=int.Parse("test");
                int a=int.Parse("-200000000000");
            }
            catch (ArgumentException ex )
            {
                
                Console.WriteLine("boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("çok küçük yada çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("işlem başarıyla tamamlandı.");
            }
        }
    }
}
