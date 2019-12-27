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
            Console.Write("Sınıf mevcudu giriniz: ");
            int sayigir = Convert.ToInt32(Console.ReadLine());
            string[] sinif = new string[sayigir];
            Console.WriteLine("İsimleri eksiksiz giriniz: ");
            
            for (int i = 0; i < sinif.Length; i++)
                sinif[i] = Console.ReadLine();
            
            Console.WriteLine("Sınıf Listesi;");
/*          for (int i = 0; i < sinif.Length; i++)
                Console.WriteLine(sinif[i]);
            
*/            string s= String.Join(", ",sinif);
            Console.WriteLine(s);
        }
    }
}
