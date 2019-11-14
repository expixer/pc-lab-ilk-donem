using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizesoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayac = 0;

            for (;;)

            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Negatif Sayı Girdiniz!");
                    continue;
                }
                else if (sayi == 0)
                    break;
                else if (sayi > 0)
                {
                    toplam += sayi;
                    sayac++;
                    continue;
                }

            }
            Console.WriteLine("sayıların toplamı "+toplam);
            Console.WriteLine("kaç sayı girdiğiniz "+sayac);
        }
    }
}
