using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayiYapimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Adet Sayı Üretmek İstiyorsunuz?");
            int adet = int.Parse(Console.ReadLine());
            int sayi;
            Random rnd = new Random();
            int[] sayilar = new int[adet];
            int sayac = 0;

            while (sayac < adet)
            {
                sayi = rnd.Next(0, 1000);
                if (Array.IndexOf(sayilar, sayi) == -1)
                {
                    sayilar[sayac] = sayi;
                    sayac++;
                }
            }
            Console.Write("Küçükten Büyüğe Sıralanmış Hali");
            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 75);
                Console.Write(sayilar[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
