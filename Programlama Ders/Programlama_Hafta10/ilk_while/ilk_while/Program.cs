using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i < 1000)
            {
                Console.Write(i + " ");
                i = i * i;

            }
        }


        }
    }
}
