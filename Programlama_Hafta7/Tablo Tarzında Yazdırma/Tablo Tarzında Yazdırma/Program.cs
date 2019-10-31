using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablo_Tarzında_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            for (int i = 0; i <= 100; i += 5)
            {
                if (adet % 6 == 0)
                    Console.WriteLine();
                Console.Write("{0,5}", i); // 0,5    5 elemanlık yer aç en sağa yaz demek 
                adet++;
            }
            Console.WriteLine("\n");
        }
    }
}
