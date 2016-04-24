using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tutulanSayi;
            int tahmin;

            Random sayiTutucu = new Random();
            tutulanSayi = sayiTutucu.Next(1, 11);

            Console.WriteLine("Lütfen 1 ile 10 arasında bir tahminde bulunun");
            do
            {
                string girilenDeger = Console.ReadLine();
                tahmin = int.Parse(girilenDeger);
                if (tahmin == tutulanSayi)
                {
                    Console.WriteLine("Tebrikler");
                }
                else
                {
                    if (tahmin < tutulanSayi)
                    {
                        Console.WriteLine("Daha yüksek bir değer girmelisiniz. Lütfen tekrar deneyin.");
                    }
                    else
                    {
                        Console.WriteLine("Daha düşük bir değer girmelisiniz. Lütfen tekrar deneyin.");
                    }
                }
            } while (tahmin != tutulanSayi);
        }
    }
}