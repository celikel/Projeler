using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiAvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sistemSayisi = r.Next(0, 10);

            Console.WriteLine("Sistem 0 ile 10 arasında bir sayı üretti. Bu sayıyı tahmin edin.");

            while (true)
            {
                string deger = Console.ReadLine();
                int sayi = int.Parse(deger);

                if (sayi == sistemSayisi)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                else if (sayi < sistemSayisi)
                {
                    Console.WriteLine("Yazdığınız değer sistem sayısından küçüktür. Lütfen tekrar deneyin.");
                }
                else
                {
                    Console.WriteLine("Yazdığınız değer sistem sayısından büyüktür. Lütfen tekrar dene.");
                }
            }
            Console.ReadLine();
        }
    }
}