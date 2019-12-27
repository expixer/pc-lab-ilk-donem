using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bölüm_Kalanı_Gösterme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Böleni girin: ");
            int bolen = Convert.ToInt32(Console.ReadLine());
            int bolum = sayi / bolen;
            int kalan = sayi % bolen;
            Console.WriteLine("Bölüm: " + bolum + "\nKalan: " + kalan);
        }
    }
}
