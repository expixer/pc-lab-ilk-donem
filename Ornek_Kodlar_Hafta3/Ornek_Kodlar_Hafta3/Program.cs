using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 530.52f;
            double b;
            checked
            {
                b = (double)a;
            }
            Console.WriteLine(b);

            string abc = "20";
            int def = Convert.ToInt32(abc);
            int xyz = def + 5;
            Console.WriteLine(xyz);

            int k = 5;
            int j = 3;
            string s1 = k.ToString();
            string s2 = j.ToString();

            Console.WriteLine(k + j);
            Console.WriteLine(s1 + s2);
        }
    }
}
