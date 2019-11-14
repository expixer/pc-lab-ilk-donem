using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizesoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int gir = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= gir; i++)
            {
                toplam += i * i * (i + 1);
            }
            Console.WriteLine(toplam);
        }
    }
}
