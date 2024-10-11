using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaireninAlanı();
        }
        static void DaireninAlanı()
        {
            Console.Write("Lütfen Dairenin Yarı çapını Giriniz: ");
            double r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            double alan = pi * (r * r);
            Console.WriteLine("Dairenin Alanı: " + alan);
            Console.ReadKey();
        }
    }
}
