using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Para miktarını giriniz: ");
            int para = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dolar için 1 Euro için 2 giriniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("{0} TL = {1} Dolar", para, para / 5);
                    break;
                case 2:
                    Console.WriteLine("{0} TL = {1} Euro", para, para / 7);
                    break;
            
            }

                
        }
    }
}
