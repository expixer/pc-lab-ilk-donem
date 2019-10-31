using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta6devam
{
    class Program
    {
        static void Main(string[] args)
        {

            int basarisiz = 0, orta = 0, basarili = 0, i, ogrenci_sayisi, puan;
            Console.WriteLine("Öğrenci sayısını giriniz: ");
            ogrenci_sayisi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= ogrenci_sayisi;)
            {

                Console.WriteLine("Puanı giriniz: ");
                puan = Convert.ToInt32(Console.ReadLine());
                if (puan < 0 || puan > 100)

                {
                    Console.WriteLine("Yanlış bir not girdiniz, tekrar not giriniz.");
                }
                else if (puan >= 0 && puan < 40)
                {
                    basarisiz++;
                    i++;
                }
                else if (puan >= 40 && puan < 70)
                {
                    orta++;
                    i++;
                }
                else
                {
                    basarili++;
                    i++;
                }

            }
            Console.WriteLine("{0} öğrenciden {1} öğrenci başarısız, " + "{2} öğrenci orta ve {3} öğrenci başarılı olmuştur",
                ogrenci_sayisi, basarisiz, orta, basarili);

        }
    }
}
