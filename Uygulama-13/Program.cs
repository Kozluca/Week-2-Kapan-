using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeName();
        }
        static void ChangeName()
        {    // ilk girilen isim ile ikinci girilen ismin yerini değiştriren method
            Console.Write("İlk İsmi Girin: ");
            string name = Console.ReadLine();
            Console.Write("İkinci İsmi Girin: ");
            string name2 = Console.ReadLine();
            string namechange = name2;
            string namechange2 = name;
            Console.WriteLine("İlk isim : " + name2);
            Console.WriteLine("İkinci isim: " + name);
            Console.ReadKey();
        }
       
    }
}
