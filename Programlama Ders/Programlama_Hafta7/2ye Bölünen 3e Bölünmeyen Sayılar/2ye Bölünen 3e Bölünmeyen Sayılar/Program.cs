using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ye_Bölünen_3e_Bölünmeyen_Sayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, yedek;
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
            Console.WriteLine("Ortalama= {0}", (float)toplam / adet);
        }
    }
}
