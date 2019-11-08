using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiyiharfleyazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int birlik = 0, onluk = 0, sayi;
            string c = "", d = "";

            sayi = Convert.ToInt32(Console.ReadLine());
            birlik = sayi % 10;
            onluk = sayi - (sayi % 10);
            switch (birlik)
            {
                case 0:
                    break;
                case 1:
                    c = "bir";
                    break;
                case 2:
                    c = "iki";
                    break;
                case 3:
                    c = "üç";
                    break;
                case 4:
                    c = "dört";
                    break;
                case 5:
                    c = "beş";
                    break;
                case 6:
                    c = "altı";
                    break;
                case 7:
                    c = "yedi";
                    break;
                case 8:
                    c = "sekiz";
                    break;
                case 9:
                    c = "dokuz";
                    break;
            }
            switch (onluk)
            {
                case 0:
                    break;
                case 10:
                    d = "on";
                    break;
                case 20:
                    d = "yirmi";
                    break;
                case 30:
                    d = "otuz";
                    break;
                case 40:
                    d = "kırk";
                    break;
                case 50:
                    d = "elli";
                    break;
                case 60:
                    d = "atmış";
                    break;
                case 70:
                    d = "yetmiş";
                    break;
                case 80:
                    d = "seksen";
                    break;
                case 90:
                    d = "doksan";
                    break;

            }
            Console.WriteLine(d + " " + c);
        }
    }
}
