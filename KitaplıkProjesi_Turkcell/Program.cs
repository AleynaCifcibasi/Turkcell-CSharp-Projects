using System;
using System.IO;
namespace KitaplıkProjesi_Turkcell
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi   **  Yabancı Kitaplar Kategorisi       **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri       **  7-Tuna Kılavuzu: Jules Verne      **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri         **  8-Bir Kuzey Macerası: Jack London **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal:Halide Edip **  9-Altıncı Koğuş: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar : O.Atay **  10-Kumarbaz: Dostoyeveski         **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: H.Yücel**  11-İki Şehrin Hikayesi: C.Dickens **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali     **  12-Vişne Bahçesi: Anton Çehov     **");
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşiivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemin Numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütffen fiyatını öğrenmek istediğniz kitabın numarasını giriniz:");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1":
                        Console.WriteLine("Çalıkuşu:  25 TL");
                        break;
                    case "2":
                        Console.WriteLine("Yaban: 30 TL");
                        break;
                    case "3":
                        Console.WriteLine("Sinekli Bakkal: 20 TL");
                        break;
                    case "4":
                        Console.WriteLine("Tehlikeli Oyunlar: 15 TL");
                        break;
                    case "5":
                        Console.WriteLine("Geçtiğim Günlerden Fiyatı: 10 TL");
                        break;
                    case "6":
                        Console.WriteLine("Kuyucaklı Yusuf: 35 TL");
                        break;
                    case "7":
                        Console.WriteLine("Tuna Kılavuzu: 40 TL");
                        break;
                    case "8":
                        Console.WriteLine("Bir Kuzey Macerası: 45 TL");
                        break;
                    case "9":
                        Console.WriteLine("Altıncı Koğuş: 50 TL");
                        break;
                    case "10":
                        Console.WriteLine("Kumarbaz: 55 TL");
                        break;
                    case "11":
                        Console.WriteLine("İki Şehrin Hikayesi: 60 TL");
                        break;
                    case "12":
                        Console.WriteLine("Vişne Bahçesi: 65 TL");
                        break;
                }

            }
            if (islem == '2')
            {

                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız:");
                ad = Console.ReadLine();
                Console.Write("Soyadınız:");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz:");
                universite = Console.ReadLine();

                // Console.Write(ad + " " + soyad + " "+ universite);

                string dosya = @"C:\Users\Aleyna\Desktop\kullanıcılar.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız:" + ad);
                sw.WriteLine("Soyadınız:" + soyad);
                sw.WriteLine("Üniversiteniz:" + universite);
                sw.Close();

            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
                
               
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Aleyna\Desktop\Kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();

                while (metin != null) 
                {
                     Console.WriteLine(metin);
                    metin = sr.ReadLine();
                   
                }
                sr.Close();
                fs.Close();

                Console.WriteLine();
                Console.WriteLine("************************************");

            }
            if (islem == '5')
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Alacacağınız kitabın numarasını giriniz:");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamfiyat += 25;
                    }
                    else if (secim == "2")
                    {
                        toplamfiyat += 30;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat += 20;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat += 15;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat += 10;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat += 35;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat += 40;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat += 45;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat += 50;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat += 55;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat += 60;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat += 65;
                    }
                    else
                    
                        Console.WriteLine("Lütfen geçerli bir numara giriniz.");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak istiyor musunuz? (E/H)");
                        string cevap = Console.ReadLine();
                        if (cevap.ToUpper() == "H")
                        
                            Console.WriteLine("Toplam Fiyat: " + toplamfiyat + " TL");
                            break;
                        
                        
                    
                    
                }
                Console.WriteLine("Toplam Fiyat: " + toplamfiyat + " TL");

            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                Console.WriteLine("1 ile 100 arasında bir sayı tahmin ediniz.");

                while (sayi != tahmin)
                {
                    Console.Write("Tahmininiz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());

                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı tahmin ediniz.");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı tahmin ediniz.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    }
                }


            }


            Console.Read();
        }
    }
}
