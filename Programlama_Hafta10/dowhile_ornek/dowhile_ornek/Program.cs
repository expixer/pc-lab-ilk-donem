using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            do {
               x = x - 3;
            } while(x > 0);
            Console.Write("{0} ", x);
            
        }
    }
}
