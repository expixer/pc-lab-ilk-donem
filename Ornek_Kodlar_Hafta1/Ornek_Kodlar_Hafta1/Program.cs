using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "tartar";
            string verial = Console.ReadLine() + " deneme";
            Console.WriteLine("Selam " + isim + " " + verial);

            int a = 5;
            int b = 3;

            int c = a + b;
            Console.WriteLine("a+b= " + c);
        }
    }
}
