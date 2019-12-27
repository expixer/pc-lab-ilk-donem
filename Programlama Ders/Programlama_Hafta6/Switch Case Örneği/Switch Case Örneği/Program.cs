using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a;
            Console.Write("Kaçıncı Sınıftasınız: ");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            switch (a)
            {
                case 1:
                    Console.WriteLine("Daha Yenisiniz");
                    break;
                case (2):
                    Console.WriteLine("Mirasçısınız");
                    break;
                case (3):
                    Console.WriteLine("Ev Sahibisiniz");
                    break;
                case (4):
                    Console.WriteLine("Siz okulu uzatmışsınız");
                    break;
            }
        }
    }
}
