using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutludizi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 4];
            int k = 1;
            for (int i = 0; i < 4; i++)
            
                for (int j = i; j < 4; j++)
                {
                    dizi[i, j] = k;
                    dizi[j, i] = k;
                    k++;
                }
            
            k = 1;
            foreach (int x in dizi)
            {
                Console.Write("{0,3}",x);
                if (k % 4 == 0)
                {
                    Console.WriteLine(); 
                }
                k++;
            }
        }
    }
}
