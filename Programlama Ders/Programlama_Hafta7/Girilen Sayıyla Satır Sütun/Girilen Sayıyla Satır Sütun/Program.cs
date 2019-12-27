using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayıyla_Satır_Sütun
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun, j;
            Console.Write("Satır sayısı: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sutun sayısı: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < satir; i++)
            {
                for ( j = 0; j < sutun; j++)
                    Console.Write(i);
                Console.WriteLine();


            }
        }
    }
}
