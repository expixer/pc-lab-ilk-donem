using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int fiyat = Convert.ToInt32(Console.ReadLine());
              int kargoucreti = 10;
              if (fiyat >= 100)
              {
                  Console.WriteLine("Ödeyeceğiniz Ücret " + fiyat);
              }
              else if(fiyat>=50)
              {
                  Console.WriteLine("Ödeyeceğiniz Ücret " + (fiyat + kargoucreti+ (-7)));
              }
              else if (fiyat >= 30)
              {
                  Console.WriteLine("Ödeyeceğiniz Ücret " + (fiyat + kargoucreti+ (-5)));
              }
              else
              {
                  Console.WriteLine("Ödeyeceğiniz Ücret " + (fiyat + kargoucreti + (-3)));
              } */

            int not=Convert.ToInt32(Console.ReadLine());
            if (not >= 90)
            {
                Console.WriteLine("Notunuz AA geçtiniz");
            }
            else if (not >= 80)
            {
                Console.WriteLine("Notunuz BB geçtiniz");
            }
            else if (not >= 70)
            {
                Console.WriteLine("Notunuz CC geçtiniz");
            }
            else if (not >= 60)
            {
                Console.WriteLine("Notunuz DD geçtiniz");
            }
            else
            {
                Console.WriteLine("Notunuz FF kaldınız");
            }
        }
    }
}
