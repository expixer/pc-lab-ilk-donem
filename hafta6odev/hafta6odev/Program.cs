using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta6odev
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int sayi1, sayi2, yedek;
             int adet = 0, toplam = 0;
             Console.WriteLine("Sayıları giriniz");
             sayi1 = Convert.ToInt32(Console.ReadLine());
             sayi2 = Convert.ToInt32(Console.ReadLine());
             if (sayi1 > sayi2)
             {
                 yedek = sayi1;
                 sayi1 = sayi2;
                 sayi2 = yedek;
             }
             for (int i = sayi1; i <= sayi2; i++)
             {
                 if ((i % 2 == 0) && (i % 3 != 0))
                 {
                     toplam = toplam + i;
                     adet++;
                 }
             }
             Console.WriteLine("{0} sayı bulundu", adet);
             Console.WriteLine("Toplam= {0}", toplam);
             Console.WriteLine("Ortalama= {0}", (float)toplam/adet); */



            /*7int adet = 0;
             for (int i = 0; i <= 100; i += 5)
             {
                 if (adet % 6 == 0)
                     Console.WriteLine();
                 Console.Write("{0,5}", i); // 0,5    5 elemanlık yer aç en sağa yaz demek 
                 adet++;
             }
             Console.WriteLine("\n");
             */


            /*
            int satir, sutun;
            Console.Write("Satır sayısı: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sutun sayısı: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                
                    Console.Write(i);
                    Console.WriteLine();
                
              
            }*/




            /*

            int Max = 0, Min = 100, Toplam = 0, adet = 6, not;
            for (int i = 0; i < adet;)
            {
                Console.Write("Notu giriniz: ");
                not = Convert.ToInt32(Console.ReadLine());
                if (not < 0 || not > 100)
                    Console.WriteLine("Yanlış not...");
                else
                {
                    if (not > Max)
                        Max = not;
                    if (not < Min)
                        Min = not;

                    Toplam += not;
                    i++;
                }
            }
            Console.WriteLine("En yüksek not: {0}", Max);
            Console.WriteLine("En düşük not: {0}", Min);
            float Ortalama = (float)Toplam / (float)adet;
            Console.WriteLine("Ortalama   :{0}", Ortalama);
            */




        }
    }
}
