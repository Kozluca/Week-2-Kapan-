using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekmiÇiftmi();
        }
        static void TekmiÇiftmi()
        {
            Console.Write("Lütfen bir sayı Giriniz: ");
            int GirilenSayi = Convert.ToInt32(Console.ReadLine());
            if (GirilenSayi % 2 == 0)  // girilen sayının 2 ye bölümünde kalan 0 ise çifttir
            {
                Console.WriteLine("Girilien Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Tektir.");
            }
            Console.ReadKey();

        }
    }
}
