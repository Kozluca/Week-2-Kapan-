using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Firstname = ("Gülse Birsel");
            string Secondname = ("Demet Evgar");
            string changename1 = Secondname;
            string changename2 = Firstname;
            Console.WriteLine(Firstname + "," + Secondname);
            Console.WriteLine("İlk isim = " + changename1 + " İkinci isim :" + changename2);
            Console.ReadKey();
        }
    }
}
