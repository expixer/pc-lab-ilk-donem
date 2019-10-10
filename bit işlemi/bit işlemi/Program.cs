using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_işlemi
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 10; int b = 2;
                Console.WriteLine("bit ve işlemi=" + (int)(a & b));
                Console.WriteLine("bit veya işlemi=" + (int)(a | b));
                Console.WriteLine("bit tümleyen işlemi=" + (int)(~a));
                Console.WriteLine("bit sola kaydırma işlemi=" + (int)(1 << b));
                Console.WriteLine("bit sağa işlemi=" + (int)(1 >> b));
                Console.WriteLine("bit xor işlemi=" + (int)(1 ^ b));
                Console.WriteLine("bit tümleyen işlemi=" + (byte)(~a));
            }
    }
}
