using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_faiz_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            double borc = 50;
            while (borc < 100)
            { 
                borc = borc + borc * 2 / 100;
                sayac++;
            }
            Console.WriteLine(borc + " \n"+ sayac);
        }
        
    }
}
