using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Dizi = { 1, 2, 3, 4, 5 };
            foreach (int eleman in Dizi)
                Console.Write(eleman + " ");
            Console.WriteLine("\n\n*********");

            Random rnd = new Random();
            int[] RastGeleDizi = new int[100];

            for (int i = 0; i < 100; i++)
            {
                RastGeleDizi[i] = rnd.Next(1, 11);
            }
            int[] adet = new int[10];
            for (int i = 0; i < 100; i++)
                adet[RastGeleDizi[i] - 1]++;
            for (int i = 0; i < 10; i++)
                Console.WriteLine("{0,3} adet {1,3}", adet[i], i+1);
        }
    }
}
