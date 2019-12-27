using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] girilen = new int[6];
            for (int i = 0; i < 6;)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz. ", i + 1);
                girilen[i] = Convert.ToInt32(Console.ReadLine());
                if (girilen[i] < 1 || girilen[i] > 49)
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz. ");
                else
                    i++;
            }
            int[] loto = new int[6];
            int gecici;
            for (int i = 0; i < 6;)
            {
                Random rnd = new Random();
                gecici = rnd.Next(1, 49);
                if (Array.IndexOf(loto, gecici) < 0)
                {
                    loto[i] = gecici;
                    i++;
                }
                else
                    continue;
            }
            for (int i = 0; i < 6; i++)
                Console.Write("{0,3}", loto[i]);
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
                Console.Write("{0,3}", girilen[i]);
            Console.WriteLine();
            for (int i = 0; i < 6;)
            {
                if (loto[i] == girilen[i])

                    i++;
                else
                {
                    Console.WriteLine("{0} sayı tutturdunuz", i);
                    break;
                }
                if (i == 6)
                    Console.WriteLine("Tebrikler lotoyu kazandınız.");
            }
        }
    }
}
