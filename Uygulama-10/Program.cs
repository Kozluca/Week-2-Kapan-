using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yüzmeyi sever misin ? " +Cevap(true));
            Console.WriteLine("Asgari ücret yeterli mi ?"+Cevap(false));
            Console.ReadKey();
        }
       static  string Cevap(bool a)
        {
            return a ? "EVET" : "HAYIR";
        }
    }
}
