using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnBuyukDeger();
        }
        static public int EnBuyukDeger()
        {
            Console.Write("Kaç Adet sayı Girmek istersiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] Girilendizi = new int[adet]; // kaç elemanlı dizi olduğunu belirledik
            for (int i = 0; i < Girilendizi.Length; i++)
            {
                Console.Write(i + 1 + ". Sayı: ");  // girilen adet miktarı kadar sayıyı diziye ekledik
                Girilendizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int BüyükSayı = Girilendizi[0]; // BüyükSayı adında bir int değeri tanımladık ve dizinin ilk elamanına eşitledik
            for (int i = 0; i < Girilendizi.Length; i++)
            {
                if (Girilendizi[i] > BüyükSayı) // dizideki herhangi bir eleman "Büyük sayı"dan büyük olursa yeni büyük sayı o olu
                {
                    BüyükSayı = Girilendizi[i];
                }
            }
            Console.WriteLine("EN BÜYÜK SAYI : " + BüyükSayı);
            Console.ReadKey();
            return BüyükSayı;
        }
    }
}





