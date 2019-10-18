using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Kodlar_Hafta5
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeni = Convert.ToInt32(Console.ReadLine());
            int kargoucreti = 10;
            if (yeni > 100)
            {
                Console.WriteLine("Ödeyeceğiniz Ücret " + yeni);
            }
            else
            {
                Console.WriteLine("Ödeyeceğiniz Ücret " + (yeni + kargoucreti));
            }
        }
    }
}
