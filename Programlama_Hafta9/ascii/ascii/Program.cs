﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dizi = new int[20];
            char[] chr = new char[20];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 51);
                chr[i] = (char)r.Next(33, 126);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0,2}. değer {1,2} ----->", i, dizi[i] );
                for (int j = 0; j < dizi[i]; j++)
                    Console.Write(chr[i]);
                Console.WriteLine();
            }
        }
    }
}
