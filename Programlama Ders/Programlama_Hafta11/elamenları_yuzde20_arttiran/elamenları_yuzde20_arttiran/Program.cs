using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elamenları_yuzde20_arttiran
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 10, 20, 30,40,50,60,70,80,90,100 };

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("sayı: "+dizi[i]);
                dizi[i] += dizi[i] * 20 / 100;
                Console.WriteLine(" Yüzde 20 fazlası: "+dizi[i]);
            }

        }
    }
}
