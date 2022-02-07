using System;
using System.Collections;
using System.Collections.Generic;
void TaslakYazıcı() 
{
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*****************************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");
Console.WriteLine("(6) Konsolu Kapatmak");
}
KisiYonetimi Secenekler = new KisiYonetimi();

List<Kisi> Rehber= new List<Kisi>(); 
           Rehber.Add(new Kisi("Seher","Elbasan","1234567"));
           Rehber.Add(new Kisi("Ayşe","Yılmaz","852963741"));
           Rehber.Add(new Kisi("Erhan","Büyük","369258147"));
           Rehber.Add(new Kisi("Mert","Tunç","123654789"));
           Rehber.Add(new Kisi("İpek", "Tunç","789951745"));

           

void KonsolIslemcisi()
{
int islem =0;
int KonsolKapatıcı=0;
while(KonsolKapatıcı!=6)
{   
switch (islem)
    {
    case 1:
    Secenekler.KisiYarat(Rehber);
    KonsolIslemcisi();
    break;
    case 2:
    Secenekler.KisiSil(Rehber);
    KonsolIslemcisi();
    break;
    case 3:
    Secenekler.KisiGuncelle(Rehber);
    KonsolIslemcisi();
    break;
    case 4:
    Secenekler.KisileriListele(Rehber);
    KonsolIslemcisi();
    break;
    case 5:
    Secenekler.KisiArama(Rehber);
    KonsolIslemcisi();
    break;   
    case 6:
    KonsolKapatıcı=6; 
    Console.WriteLine("Console'dan başarılı bir şekilde çıkış yapıldı, yine bekleriz :=)"); 
    break; 
    }
    
    
if(islem<1 || islem>6)
{
    Console.WriteLine("Lütfen 1-6 arası bir rakam girdiğinizden emin olunuz.\n");
    TaslakYazıcı();
    if(int.TryParse(Console.ReadLine(), out int TryParsedIslem)) 
    {
        islem =TryParsedIslem;
    }else
    {
        Console.WriteLine("Lütfen 1-6 arası rakam girdiğinizden emin olunuz.\n");
        TaslakYazıcı();
        KonsolIslemcisi();
    }
    
    continue; 
}
}

}

KonsolIslemcisi(); 

class Kisi{ 
    public Kisi(string isimGirdisi, string soyIsimGirdisi, string numara)
    {
        isim=isimGirdisi;
        soyIsim=soyIsimGirdisi;
        telNo= numara;
    }
    string isim; 
    string soyIsim; 
    string telNo;  
    public string Isim 
    {
        get
        {
            return isim;
        }
        set{
            isim=value;
        }
    }
    public string SoyIsim{
        get{
            return soyIsim;
        }
        set{
            soyIsim=value;
        }
    }
    public string TelNo
    {

        get
        {
            return telNo;
        }
        set
        {
            telNo=value;
        }
    }
}

class KisiYonetimi 
{
    public void KisiYarat(List<Kisi> rehber) 
    {
        Console.Write("Lütfen isim giriniz:  ");
        string isim=Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz:  ");
        string soyisim= Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz:  ");
        string numara=Console.ReadLine();
        Kisi yeniInsan = new Kisi(isim,soyisim,numara);
        rehber.Add(yeniInsan);
    }
        public void KisiSil(List<Kisi> list) 
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input =Console.ReadLine();
            int durum=0;             
                foreach (var item in list)
            {
                if(item.Isim ==input || item.SoyIsim== input)
                {
                   Console.Write($" {item.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n):");
                   string cevap=Console.ReadLine();
                   if(cevap=="y")
                   {
                       list.Remove(item);
                       durum++; 
                       break;
                   }else if(cevap=="n")
                   {
                    break;
                   }
                }
                
            } 
            if (durum==0)
            {
                
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    Console.Write("Yapmak istediğiniz işleme tekabül eden sayıyı giriniz:");
                    int cevap =int.Parse(Console.ReadLine());
                    if(cevap==1)
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        
                    }else if(cevap==2)
                    {
                        KisiSil(list);
                    }
                
            }
        
        }
        public void KisiGuncelle(List<Kisi> list)
        {
            Console.Write("Lütfen güncellemek istediğiniz numarayı giriniz:");
            string numara= Console.ReadLine();
            
            int durum=0; 
            foreach (var item in list) 
            {
                if (item.TelNo==numara) 
                {
                    Console.Write("Lütfen yeni ismi giriniz:");
                    item.Isim=Console.ReadLine();
                    Console.Write("Lütfen yeni soyismi giriniz:");
                    item.SoyIsim=Console.ReadLine();
                    Console.WriteLine("Girdiğiniz numaranın bilgileri başarıyla güncellendi.\n");
                    durum++;
                    break;
                }
            }
            if(durum==0) 
            {
                void VeriBulunamadı() 
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız:");
                    Console.Write("* Güncellemeyi sonlandırmak için: (1)\n* Yeniden denemek için: (2)");
                    int islemNo=int.Parse(Console.ReadLine());
                    if (islemNo==1)
                    {

                    }
                    else if(islemNo==2)
                    {
                        KisiGuncelle(list);
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz veri 1 veya 2 olarak algılanamadı.");
                        VeriBulunamadı();

                    }
                }
                VeriBulunamadı();
                    
            }
            
        }
          public void KisileriListele(List<Kisi> list) 
        {
            Console.WriteLine("Telefon Rehberi\n*****************************************************");
            foreach (var item in list)
            {
                Console.WriteLine($"İsim: {item.Isim}");
                Console.WriteLine($"Soyisim: {item.SoyIsim}");
                Console.WriteLine($"Telefon Numarası: {item.TelNo}");
                Console.WriteLine("-----------------------------------------------------");
                
            }
            Console.WriteLine("Rehber burada sonlanmıştır :=)\n*****************************************************");
        } 


        public void KisiArama(List<Kisi> list)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n*****************************************************\n");
            Console.Write("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
            
            void Proceccor(int islemNo)
        {
                if(islemNo==1)
            {
                Console.Write("Lütfen aramak istediğiniz ismi veya soyismi yazınız:");
                string input=Console.ReadLine();
                int durum=0;
                foreach (var item in list)
                {
                    if (item.Isim==input || item.SoyIsim==input)
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine($"İsim: {item.Isim}");
                        Console.WriteLine($"Soyisim: {item.SoyIsim}");
                        Console.WriteLine($"Telefon Numarası: {item.TelNo}");
                        Console.WriteLine("-----------------------------------------------------");
                        durum++;
                    }
                }
                if (durum==0)
                {
                    
                        Console.WriteLine("Aradığınız isim veya soyismi bulamadık.");
                        Console.WriteLine("İşlemi sonlandırmak için: (1)\n Tekrar arama yapmak için: (2)");
                        int yesOrNo=int.Parse(Console.ReadLine()); 
                        if (yesOrNo==1)
                        {
                            
                        }
                        else if(yesOrNo==2)
                        {
                            KisiArama(list);
                        }
                    
                }
            }else if(islemNo==2)
            {
                int durum2=0;
                Console.Write("Lütfen aramak istediğiniz telefon numarasını yazınız:");
                string numara=Console.ReadLine();
                foreach (var item in list)
                {
                    if (item.TelNo==numara)
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine($"İsim: {item.Isim}");
                        Console.WriteLine($"Soyisim: {item.SoyIsim}");
                        Console.WriteLine($"Telefon Numarası: {item.TelNo}");
                        Console.WriteLine("-----------------------------------------------------");
                        durum2++;
                    }
                }
                if (durum2==0)
                {
                    
                        Console.WriteLine("Aradığınız numarayı bulamadık.");
                        Console.WriteLine("İşlemi sonlandırmak için: (1)\nTekrar arama yapmak için: (2)");
                        int yesOrNo=int.Parse(Console.ReadLine());
                        if (yesOrNo==1)
                        {
                            
                        }
                        else if(yesOrNo==2)
                        {
                            KisiArama(list);
                        }
                    
                }
            }
        }
            if (int.TryParse(Console.ReadLine(), out int Checker) && Checker==1 || Checker==2 ) 
            {
                int islemNo= Checker;
                Proceccor(islemNo);
            }else
            {
                Console.WriteLine("Girdiğiniz veri 1 veya 2 olarak algılanamadı, lütfen tekrar deneyiniz\n");
                KisiArama(list);
            }
        }
}