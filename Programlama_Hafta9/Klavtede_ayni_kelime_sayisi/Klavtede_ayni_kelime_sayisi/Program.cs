using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavtede_ayni_kelime_sayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac =0;
            string kelime = "";
            Boolean s = false;
            string cumle = Console.ReadLine();
            string sozcuk = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] != ' ')
                {
                    kelime += cumle[i];
                }
                else
                {
                    if (kelime == sozcuk)
                    {
                        sayac++;
                    }
                    kelime = "";
                }                
            }
            if (kelime == sozcuk)
            {
                sayac++;
            }
            Console.WriteLine(sayac);
        }
    }
}
