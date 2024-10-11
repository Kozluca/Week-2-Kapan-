using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnYaslıOlan();
        }

        static int EnYaslıOlan()
        {
            Console.WriteLine("Lütfen Yaşları giriniz: ");  // Yaşları girdik
            int Yaş1 = Convert.ToInt32(Console.ReadLine());
            int Yaş2 = Convert.ToInt32(Console.ReadLine());
            int Yaş3 = Convert.ToInt32(Console.ReadLine());
            if (Yaş1 > Yaş2 && Yaş1 > Yaş3)  //  En büyük olanı bulmak  için gerekli koşulları girik
            {
                Console.WriteLine("En Yaşlı olan:  " + Yaş1);
                Console.ReadKey();
                return Yaş1;  
            }
            else if (Yaş2 > Yaş1 && Yaş2 > Yaş3)
            {
                Console.WriteLine("En Yaşlı olan:  " + Yaş2);
                Console.ReadKey();
                return Yaş2;
            }
            else
            {
                Console.WriteLine("En Yaşlı olan:  " + Yaş3);
                Console.ReadKey();
                return Yaş3;
            }
        }// En büyük olan yaşı yazdırdık
    }
}
