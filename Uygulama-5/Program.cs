using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Yaşınızı Giriniz :");
            int Yaş=Convert.ToInt32(Console.ReadLine());
            if(Yaş>18)    // yaş 18 den büyükse şart sağlanır 
            {
                Console.WriteLine("+");
            }
            else  // yaş 18 den küçüksse şart sağlanır
            {
                Console.WriteLine("-");
            }
            
            #region MyRegion
            Console.Write("Lütfen Yaşınızı Girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yas > 17 ? "+" : "-");
            Console.ReadKey();
            #endregion
        }
        
    }
}
