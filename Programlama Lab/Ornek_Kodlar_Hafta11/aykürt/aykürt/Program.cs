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
            Console.Write("Küme uzunluğunu giriniz: ");
            int t = Convert.ToInt32(Console.ReadLine());
            int[] sayi = new int[t];
            Console.Write("Kümeye sayılarını giriniz: ");
            for (int i = 0; i < sayi.Length; i++)
               sayi[i]=Convert.ToInt32(Console.ReadLine());

            Console.Write("Bir sayı giriniz: ");
            int kontrol = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < sayi.Length; i++)
                if (kontrol == sayi[i])
                    sayac++;
            Console.WriteLine("Verdiğiniz sayı " +sayac+" defa var");
        }
    }
}
