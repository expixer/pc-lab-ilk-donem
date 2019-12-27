using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgele_sayiya_yaklasma
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int tutulansayi = rnd.Next(1, 100);
            int girilensayi= Convert.ToInt32(Console.ReadLine());
            while (girilensayi != tutulansayi)
            {
                if (tutulansayi < girilensayi)
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                else if (tutulansayi>girilensayi)
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                girilensayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Doğru sayıyı buldunuz.");
        }
    }
}
