using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizesoru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
                for (int i = 1; i <= 50; i++)
                {
                    sayi = sayi - 2;
                    Console.WriteLine(sayi);
                }
            else
                for (int j = 1; j <= 50; j++)
                {
                    sayi= sayi+2;
                    Console.WriteLine(sayi);
                }
        }

    }
}
