using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_kelimeyi_istendigi_kadar_yaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen bir kelimeyi istenildiği kadar yazdıran, devam etmek için nE veya çıkmak için h girmemizi isteyen program

            int i, n;
            char karar;
            string karakter;
            do
            {
                Console.WriteLine("Bir karakter giriniz: ");
                karakter = Console.ReadLine();
                Console.WriteLine("Kaç defa yazılacak? ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                    Console.WriteLine(karakter);
                Console.WriteLine();
                Console.WriteLine("Devam etmek için: E/e basiniz: ");
                karar = Convert.ToChar(Console.ReadLine());
            } while ((karar =='E')||(karar=='e'));


        }
    }
}
