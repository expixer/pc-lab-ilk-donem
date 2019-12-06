using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aykürt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac=0;
            int[] sayi = { 1, 2, 3, 4, 5, 3, 3, 3, 5, 4 };
            Console.Write("Bi sayı giriniz: ");
            int kontrol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi.Length; i++)
                if (kontrol == sayi[i])
                    sayac++;
            Console.WriteLine("Verdiğiniz sayı " +sayac+" defa var");
        }
    }
}
