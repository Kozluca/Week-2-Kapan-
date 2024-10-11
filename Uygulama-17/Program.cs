using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zaman bir GeRi SayIm");
            string metin = ("Zaman bir GeRi SayIm");
            string KücükHarf = metin.ToLower(); // kücük harfe çevirdik
            string BüyükHarf = metin.ToUpper(); // Büyük Harfe çevirdik
            Console.WriteLine(BüyükHarf);
            Console.WriteLine(KücükHarf);
            Console.ReadKey();
        }
    }
}
