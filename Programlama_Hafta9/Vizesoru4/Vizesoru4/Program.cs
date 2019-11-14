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
            int cift, tek;
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
                for (int i = 1; i <= 50; i++)
                {
                    cift = sayi - (i * 2);
                    Console.WriteLine(cift);
                }
            else
                for (int j = 1; j <= 50; j++)
                {
                    tek = sayi + (j * 2);
                    Console.WriteLine(tek);
                }
        }

    }
}
