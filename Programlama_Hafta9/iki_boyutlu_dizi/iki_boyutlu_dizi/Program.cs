using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_boyutlu_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            dizi[1, 1] = 100;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,5}", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
