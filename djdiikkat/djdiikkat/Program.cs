using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djdiikkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıf mevcudu giriniz: ");
            int sayigir = Convert.ToInt32(Console.ReadLine());
            string[] sinif = new string[sayigir];
            for (int i = 0; i < sinif.Length; i++)
            {
                Console.WriteLine("isim giriniz: ");
                sinif[i] = Console.ReadLine();
            }
            Console.WriteLine("Sınıf Listesi;");
            for (int i = 0; i < sinif.Length; i++)
            {
                Console.WriteLine(sinif[i]);
            }

        }
    }
}
