using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 530.52f;
            double d;
            checked
            {
                d = (double)f;
            }
            Console.WriteLine(d);

            string yazi = "20";
            int sayi = Convert.ToInt32(yazi);
            int toplama = sayi + 5;
            Console.WriteLine(toplama);

            int sayi1 = 5;
            int sayi2 = 3;
            Console.WriteLine(sayi1 + sayi2);

            string s1 = sayi1.ToString();
            string s2 = sayi2.ToString();

            Console.WriteLine(s1 + s2);
        }
    }
}
