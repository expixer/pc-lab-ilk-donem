using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            donustur:{ 
            Console.Write("Dönüştürmek istediğiniz TL mikatrını giriniz: ");
            double lira = Convert.ToDouble(Console.ReadLine());
            double dolaresit = lira * 0.1754;
            double euroesit = lira * 0.1515;
            Console.Write("Dolar dönüşümü için 1'e Euro dönüşümü için 2'ye basınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            double sonuc=0;
            string kur ="";
            if (secim == 1) { sonuc = dolaresit; kur = "dolar"; }
            else if (secim == 2) { sonuc = euroesit; kur = "euro"; }
            else { Console.WriteLine("Belirtilen değerlerden birini girmediniz."); goto donustur; }
            Console.WriteLine("Girdiğiniz paranın "+kur+" dönüşümü "+sonuc+" " + kur);
            }
        }
    }
}
