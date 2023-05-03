using System;

namespace sayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int sayi = rand.Next(1, 100);
            int tahmin, sayac = 0;
            do
            {
                sayac = sayac + 1;
                Console.Write(sayac + ". Tahmin: ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin < sayi && sayac < 7)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                }
                else if (tahmin > sayi && sayac < 7)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                }

            } while (tahmin != sayi && sayac != 7);
            if (tahmin == sayi)
            {
                Console.WriteLine("Tebrikler " + sayac + " denemede bildiniz");
            }
            else
            {
                Console.WriteLine("Oyun bitti, bilemediniz. Sayı : " + sayi);
            }
            Console.Write("Uygulamayı kapatmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
