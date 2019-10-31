using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta6devam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0, BirOncekiSayi = 0;
            for (; ; )
            {
                Console.Write("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    break;
                if (sayi == BirOncekiSayi)
                {
                    Console.WriteLine("Farklı bir sayı girin");
                    continue;

                }
                toplam += sayi;
                BirOncekiSayi = sayi;
            }
            Console.WriteLine("Toplam{0} ", toplam);
        }
    }
}
