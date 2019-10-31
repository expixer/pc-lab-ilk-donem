using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Döngüsü_İle_Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0, toplam = 0;
            for (int i = 1; i <= 100; i++)
            {

                if ((i % 5 == 0) && (i % 7 != 0))
                {
                    toplam = toplam + i;
                    adet++;
                }
            }
            Console.WriteLine("{0} sayı bulundu", adet);
            Console.WriteLine("Toplam={0}", toplam);
        }
    }
}
