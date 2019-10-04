using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İşlem yapılacak ilk sayıyı giriniz: ");
            string ilksayi = Console.ReadLine();
            Console.Write("İşlem yapılacak ikinci sayıyı giriniz: ");
            string ikincisayi = Console.ReadLine();
            int ilksayint = Convert.ToInt32(ilksayi);
            int ikincisayint = Convert.ToInt32(ikincisayi);
            double doubleilk = Convert.ToDouble(ilksayi);
            double doubleikinci = Convert.ToDouble(ikincisayi);
            Console.WriteLine("Sayıların toplamı: " + (ilksayint + ikincisayint) + " Sayıların Çarpımı: " + (ilksayint * ikincisayint) + " Sayıların ortalaması: " + ((doubleilk + doubleikinci) / 2));
                }
    }
}
