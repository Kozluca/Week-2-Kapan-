using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();   // rastgele bir sayı değeri aldık
            int rastgele =rnd.Next(0,201); // rastgele sayı dedğeri  aralığını belirledik
            Console.WriteLine(+rastgele);
            Console.ReadKey();
        }
    }
}
