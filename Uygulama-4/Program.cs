using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double rastgele=rnd.Next(0,500);   // 0-500 arasında rastgele sayı aldırdık
            double kalan = rastgele % 3;       // rastgele sayının 3 e bölümünden kalanı hesaplattık
            Console.WriteLine("Rastgele sayı: " + rastgele);
            Console.WriteLine("Kalan : "+kalan);
            Console.ReadKey();
            
        }
    }
}
