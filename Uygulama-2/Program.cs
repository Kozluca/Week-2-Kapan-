using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Metin Giriniz: ");
            string metin=Console.ReadLine(); //Metin Değeri aldık
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayı = Convert.ToInt32(Console.ReadLine()); // sayı değeri aldık
            Console.WriteLine("Metin: " +metin+ " Sayı: "+sayı);
            Console.ReadKey();
        }
    }
}
