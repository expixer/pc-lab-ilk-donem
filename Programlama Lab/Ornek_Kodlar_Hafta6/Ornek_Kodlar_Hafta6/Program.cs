using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta6
{
    class Program
    {
        static void Main(string[] args)
        {
        /*  Console.Write("Para miktarını giriniz: ");
          int para = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Dolar için 1 Euro için 2 giriniz: ");
          int secim = Convert.ToInt32(Console.ReadLine());

          switch (secim)
          {
              case 1:
                  Console.WriteLine("{0} TL = {1} Dolar", para, para / 5);
                  break;
              case 2:
                  Console.WriteLine("{0} TL = {1} Euro", para, para / 7);
                  break;
              default:
                  Console.WriteLine("Geçerli  bir sayı giriniz.");
                  break;

          }*/


        /*
        Console.Write("Güne çevrilecek sayıyı giriniz: ");
        int gun = Convert.ToInt32(Console.ReadLine());
        int gun2 = gun;

        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                if (gun % 7 == 0)
                    goto case 7;
                if (gun % 7== 1)
                    goto case 1;
                if (gun % 7 == 2)
                    goto case 2;
                if (gun % 7 == 3)
                    goto case 3;
                if (gun % 7 == 4)
                    goto case 4;
                if (gun % 7 == 5)
                    goto case 5;
                if (gun%7 == 6)
                    goto case 6;
                break;
        }*/










        A:
            Console.Write("Yazı rengini giriniz: ");
            string renk = Console.ReadLine();
             
            switch (renk)
            {
                case "mavi":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    goto A;
                case "yeşil":
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto A;
                case "kırmızı":
                    Console.ForegroundColor = ConsoleColor.Red;
                    goto A;
                case "sarı":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    goto A;
                default:
                    Console.WriteLine("Geçerli bir renk giriniz.");
                    goto A;


            }
            

        }
    }
}
