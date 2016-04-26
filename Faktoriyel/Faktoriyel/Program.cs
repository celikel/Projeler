using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 0'a eşit ve 0'dan büyük bir sayı gir: ");
            string deger = Console.ReadLine();
            int sayi = int.Parse(deger);

            if (sayi < 0)
            {
                Console.WriteLine("Sayı 0 veya 0'dan büyük olmalı.");
            }
            else
            {
                if(sayi < 2)
                {
                    Console.WriteLine("Sonuç:"+1);
                }
                else
                {
                    int sonuc = 1;

                    for(int i=1; i<=sayi; i++)
                    {
                        sonuc = sonuc * i;
                    }

                    Console.WriteLine("Sonuç: "+ sonuc);
                }
        }
            Console.WriteLine("Programı kapatmak için entera bas.");
            Console.ReadLine();
    }
    }
}