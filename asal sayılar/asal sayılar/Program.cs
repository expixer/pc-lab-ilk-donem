using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                int asal = 1;
                for (int j = 2; j < i; j++)
                {
                    if(i%j==0)
                    { 
                    asal = 2;
                    break;
                    }
                }
                    if (asal==1)
                        Console.WriteLine(i);
            }
        }
    }
}
