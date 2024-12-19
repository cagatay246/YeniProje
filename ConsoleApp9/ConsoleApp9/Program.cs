using System;

namespace Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            // 10 ile karşılaştırma yapma
            if (sayi == 10)
            {
                Console.WriteLine($"{sayi}sayısı 10'a eşittir.");
            }
            else if (sayi < 10)
            {
                Console.WriteLine($"{sayi} sayısı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısı 10'dan büyüktür.");
            }

            // Sayının çift mi, tek mi olduğunu kontrol etme
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} sayısı çifttir.");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısı tektir.");


            }
        }
    }
}