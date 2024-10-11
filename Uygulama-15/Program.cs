using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GidilenYol();
        }
        static void GidilenYol()
        {
            Console.Write("Hızı KM cinsinden giriniz: ");  // hız bilgisini aldık
            double Speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Süreyi dk Cinsinden Giriniz: "); // süreyi dk olarak aldık
            double Time = Convert.ToDouble(Console.ReadLine());
            double Sonuc = (Speed / 60) * (Time);    // sonuc için dönüştürme yaptık
            Console.WriteLine("Gidilen Yol: " + Sonuc+ " KM");
            Console.ReadKey();
        }
    }
}
