using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_Hafta6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Sayıyı girin: " );
             int sayi = Convert.ToInt32(Console.ReadLine());
             Console.Write("Böleni girin: ");
             int bolen = Convert.ToInt32(Console.ReadLine());
             int bolum = sayi / bolen;
             int kalan = sayi % bolen;
             Console.WriteLine("Bölüm: "+bolum+"\nKalan: " + kalan);*/
            /*double sayi = 26;
            double sayi2 = 3.5;
            int sayi3 = Convert.ToInt32(sayi % sayi2);
            Console.WriteLine(sayi3);*/

            /*  string s;
              int a;
              Console.Write("Kaçıncı Sınıftasınız: ");
              s = Console.ReadLine();
              a = Int32.Parse(s);
              switch (a) {
                  case 1:
                      Console.WriteLine("Daha Yenisiniz");
                      break;
                  case (2): Console.WriteLine("Mirasçısınız");
                      break;
                  case (3): Console.WriteLine("Ev Sahibisiniz");
                      break;
                  case (4): Console.WriteLine("Siz okulu uzatmışsınız");
                      break;
              }*/
            /*   int a = 1, b = 1;
               switch (a) {
                   case 1: Console.WriteLine("Case 1-a");
                       goto case2;
                   case2:
                       Console.WriteLine("Case 2-a");
                       break;
                   default:
                       break;*/
            /*  int sayi1, sayi2;
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
              }*/
            /*  int i, toplam = 0;
              for (i = 1; i <= 3; i++)
              {
                  toplam = toplam + i;
              }
              Console.WriteLine("Toplam={0}", toplam);
              Console.WriteLine("i={0}", i);*/
            /* char ch;
             int i = 0, j = 0, k = 0;
             for (ch = Convert.ToChar(Console.ReadLine());
             ch != 'q';
             ch = Convert.ToChar(Console.ReadLine()))
                 Console.WriteLine("\n");
                 */
            /*
       int i = 0, a, n;
       Console.Write("Bir sayı girin: ");
       n = Convert.ToInt32(Console.ReadLine());
       Console.Write("Artım miktarı: ");
       a = Convert.ToInt32(Console.ReadLine());
       for (; i < n;) {
           Console.Write("{0} ", i);
           i += a;
       }*/
            //BUNU ANLAMADIM
            /*
                 int sayi;
                 Console.Write("Bir tam sayı giriniz: ");
                 sayi = Convert.ToInt32(Console.ReadLine());
                 for (int bit = 32; bit >= 1; bit--)
                 {
                     Console.Write("{0}", (sayi >> bit - 1) & 1);
                 }*/
            int adet = 0, toplam = 0;
            for (int i = 1; i <= 1000; i++)
            {

                if ((i % 5 == 0) && (i % 7 != 0))
                {
                    toplam = toplam + i;
                    adet++;
                }
            }
            Console.WriteLine("{0} sayı bulundu", adet);
            Console.WriteLine("Toplam={0}", toplam);
        }

    }
}

