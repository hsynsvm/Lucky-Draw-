using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekilisUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çekilişe Hoşgeldiniz :) ");
            Console.WriteLine("\nKaç Kişilik Çekiliş Yapılacak?");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            string[] katilimcilar = new string[sayi];

            for (int i = 0; i < katilimcilar.Length; i++)
            {
                Console.WriteLine((i+1) + ". Katılımcı Adı: ");
                string katilimci = Console.ReadLine();
                katilimcilar[i] = katilimci;
            }
            Random rnd = new Random();
            int cekilen = rnd.Next(0,sayi-1);
            Console.WriteLine("Kazanan = " + katilimcilar[cekilen]);

        }
    }
}
