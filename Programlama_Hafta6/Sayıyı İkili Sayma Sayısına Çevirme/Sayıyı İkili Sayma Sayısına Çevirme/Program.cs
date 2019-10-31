using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayıyı_İkili_Sayma_Sayısına_Çevirme
{
    class Program
    {
        static void Main(string[] args)
        {

            //BUNU ANLAMADIM
            int sayi;
            Console.Write("Bir tam sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }
        }
    }
}
