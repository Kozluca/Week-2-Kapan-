using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Metin = "    Selamlar   ";
            Console.WriteLine("    Selamlar   "); 
            Console.WriteLine(Metin.Trim()); // Metinde ki boşlukları sildik
            Console.ReadKey();
        }
    }
}
