﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yüzde Kaçı Alınacağını Giriniz: ");
            double yuzdesi = Convert.ToDouble(Console.ReadLine());
            double islem = yuzdesi;
            islem = yuzdesi / 100;
            double sonuc = sayi * islem;
            Console.WriteLine(sayi + "'ın %" + yuzdesi + "'si " + sonuc);
            /* Başka bir yazım şekli
            Console.WriteLine(value: $"{sayi}'ın %{yuzdesi}'si {sonuc}"); */
            /* Ve başka bir yazım şekli
            Console.WriteLine("{0}'ın %{1}si {2}{1}", sayi, yuzdesi, sonuc); */
        }
    }
}
