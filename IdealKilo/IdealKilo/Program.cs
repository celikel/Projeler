using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKilo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idealkilo, boy;
            string erkek = "E";
            string kadin = "K";

            Console.WriteLine("Lütfen boyunuzu giriniz: ");
            
            string strboy = Console.ReadLine();
            boy = Convert.ToInt32(strboy);

            Console.WriteLine("Lütfen cinsiyetini gir(E/K): ");
            string cinsiyet = Console.ReadLine().ToUpper();

            if (cinsiyet == erkek)
            {
                idealkilo = boy - 100;
                Console.WriteLine("İdeal kilonuz: ");
                Console.WriteLine(idealkilo);
            }
            else if (cinsiyet == kadin)
            {
                idealkilo = boy - 110;
                Console.WriteLine("İdeal kilonuz: ");
                Console.WriteLine(idealkilo);
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız!");
            }
            Console.WriteLine("Devam etmek için enter tuşuna bas.");
            Console.Read();
        }
    }
}