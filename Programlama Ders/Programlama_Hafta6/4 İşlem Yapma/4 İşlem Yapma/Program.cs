using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_İşlem_Yapma
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2;
            string islem;
            Console.Write("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nToplam -----> t");
            Console.WriteLine("Çıkarma  -----> c");
            Console.WriteLine("Çarpma   -----> m");
            Console.WriteLine("Bölme    -----> b");

            Console.Write("İşleminizi seçiniz: ");
            islem = Console.ReadLine();
            switch (islem)
            {
                case "t":
                    Console.WriteLine("Sonuç = {0}", sayi1 + sayi2);
                    break;
                case "c":
                    Console.WriteLine("Sonuç = {0}", sayi1 - sayi2);
                    break;
                case "m":
                    Console.WriteLine("Sonuç = {0}", sayi1 * sayi2);
                    break;
                case "b":
                    switch (sayi2)
                    {
                        case 0:
                            Console.WriteLine("Bölen 0 olamaz");
                            break;
                        default:
                            float sonuc = (float)sayi1 / (float)sayi2;
                            Console.WriteLine("Sonuç = {0}", sonuc);
                            break;
                    }

                    break;
            }

        }
    }
}
