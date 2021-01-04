using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMYO.OkanErdem.SayıBulmaOyunu
{
    class Program
    {
        static void Main(string[] args)
        { //Okan ERDEM

            Console.WriteLine("Bir Seviye Seçiniz:\n1- Kolay Seviye (Sayı Aralığı: 1-10)\n2- Orta Seviye (Sayı Aralığı: 1-25)\n3- Zor Seviye (Sayı Aralığı: 1-50)");
            byte secim = byte.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Kolay Seviyeyi Seçtiniz.Bol Şanslar! :)");

                Random rnd = new Random();
                int sayi = rnd.Next(1,10);
                
                for (int i = 5; i >= 0; --i)
                {
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());

                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bilemediniz.Kalan Hak:" + (i));
                        if (i == 0)
                        {
                            Console.WriteLine("Üzgünüz...Hakkınız bitti. :(");
                            Console.WriteLine("Doğru cevap:" + sayi );
                        }
                    }
                }

            }

            else if (secim == 2)
            {
                Console.WriteLine("Orta Seviyeyi Seçtiniz.Bol Şanslar! :)");

                Random rnd = new Random();
                int sayi = rnd.Next(1,25); 

                for (int i = 3; i >= 0; --i)
                {
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());

                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bilemediniz.Kalan Hak:" + (i));
                        if (i == 0)
                        {
                            Console.WriteLine("Üzgünüz...Hakkınız bitti. :(");
                            Console.WriteLine("Doğru cevap:" + sayi);
                        }
                    }
                }

            }

            else if (secim == 3)
            {
                Console.WriteLine("Zor Seviyeyi Seçtiniz.Bol Şanslar! :)");

                Random rnd = new Random();
                int sayi = rnd.Next(1,50);

                for (int i = 1; i >= 0; --i)
                {
                    Console.WriteLine("Bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());

                    if (sayi == tahmin)
                    {
                        Console.WriteLine("BRAVO!");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bilemediniz.Kalan Hak:" + (i));
                        if (i == 0)
                        {
                            Console.WriteLine("Üzgünüz...Hakkınız bitti. :(");
                            Console.WriteLine("Doğru cevap:" + sayi);
                        }
                    }
                }

            }

            else
            {
                Console.WriteLine("Sadece 1-3 arası seçim yapabilirsiniz!");
            }

        }
    }

}
    

