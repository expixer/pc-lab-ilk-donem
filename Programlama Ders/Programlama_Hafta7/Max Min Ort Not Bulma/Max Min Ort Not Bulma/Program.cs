using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Ort_Not_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {

            int Max = 0, Min = 100, Toplam = 0, adet = 6, not;
            for (int i = 0; i < adet;)
            {
                Console.Write("Notu giriniz: ");
                not = Convert.ToInt32(Console.ReadLine());
                if (not < 0 || not > 100)
                    Console.WriteLine("Yanlış not...");
                else
                {
                    if (not > Max)
                        Max = not;
                    if (not < Min)
                        Min = not;

                    Toplam += not;
                    i++;
                }
            }
            Console.WriteLine("En yüksek not: {0}", Max);
            Console.WriteLine("En düşük not: {0}", Min);
            float Ortalama = (float)Toplam / (float)adet;
            Console.WriteLine("Ortalama   :{0}", Ortalama);

        }
    }
}
