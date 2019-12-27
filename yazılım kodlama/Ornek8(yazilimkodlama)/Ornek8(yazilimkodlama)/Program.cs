using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8_yazilimkodlama_
{
    class Program
    {
        static void Main(string[] args)
        {

            int toplam = 0, ortalama, buyuksayac = 0, kucuksayac = 0;
            Random rnd = new Random();
            int[] dizi = new int[20];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
                toplam += dizi[i];
            }
            ortalama = toplam / dizi.Length;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ortalama)
                    kucuksayac++;
                else if (dizi[i] > ortalama)
                    buyuksayac++;
            }
            Console.WriteLine("{2} sayının {0} tanesi ortalamadan küçükken {1} tanesi büyüktür.", kucuksayac, buyuksayac, dizi.Length);
        }
    }
}
