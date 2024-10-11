using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_9
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Toplam(8,15.2);
            Console.WriteLine("Toplam: " + Toplam(8, 15.2));
            Console.ReadKey();
        }
        static double Toplam(double x, double y)
        {
            return x + y;
        }

    }
}

