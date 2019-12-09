using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutludizi3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] dizi = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };
            int i, j, k;
            for (i = 0; i < 3; ++i)
                for (j = 0; j < 2; j++)
                    for (k = 0; k < 2; k++)
                        Console.WriteLine("dizi[{0},{1},{2}]={3}",
                            i, j, k, dizi[i, j, k]);
        }
    }
}
