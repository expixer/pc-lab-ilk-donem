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
        donustur: {
                double dolarkur = 1 / 5.75;
                double eurokur = 1 / 6.5;
                int kursec=0;
                int secim = 0;
                Console.Write("Dönüştürmek istediğiniz TL mikatrını giriniz(Kur düzenlemek için 0'a basınız): ");
                double lira = Convert.ToDouble(Console.ReadLine());


                if (lira == 0) {
                    Console.WriteLine("Dolar kurunu değiştirmek için 1'e Euro kurunu değiştirmek içni 2'ye basınız: ");
                    kursec= Convert.ToInt32(Console.ReadLine());
                    if (kursec == 1) { dolarkur = 1 / Convert.ToDouble(Console.ReadLine());
                        Console.Write("Dönüştürmek istediğiniz TL mikatrını giriniz: ");
                        lira = Convert.ToDouble(Console.ReadLine());
                        secim = 1;
                    }
                    else if (kursec == 2)
                    {
                     eurokur = 2 / Convert.ToDouble(Console.ReadLine());
                        Console.Write("Dönüştürmek istediğiniz TL mikatrını giriniz: ");
                        lira = Convert.ToDouble(Console.ReadLine());
                        secim = 2;
                    }
                }
            double dolaresit = lira * dolarkur;
            double euroesit = lira * eurokur;
                if (kursec==0) { Console.Write("Dolar dönüşümü için 1'e Euro dönüşümü için 2'ye basınız: "); 
             secim = Convert.ToInt32(Console.ReadLine());
                }
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
