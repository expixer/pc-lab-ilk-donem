using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_giresiye_kadar_sayi_topla
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac=0;
            int sayi = 1;
            int toplam = 0;
            while (sayi!=0)
            {
                sayac++;
                sayi =Convert.ToInt32(Console.ReadLine());
                toplam = sayi + toplam;

            }
            Console.WriteLine(sayac+" sayının toplamı "+toplam);

        }
    }
}
