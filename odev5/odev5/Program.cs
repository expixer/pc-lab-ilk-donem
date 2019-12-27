using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    class Program
    {

        static void dikdortgen(int x, int y)

        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa Kenarı girin");
            int kisa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenarı girin");
            int uzun = Convert.ToInt32(Console.ReadLine());
            dikdortgen(kisa, uzun);
        }

    }
}
