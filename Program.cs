using System;

namespace Kargo_ücreti
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int giris2;
            int giris;
            int ind;
            Console.WriteLine("Alacağınız ürünler 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek \n");
            Console.Write("1. Ürünün fiyatını girin: ");
            giris = int.Parse(Console.ReadLine());
            Console.Write("2. Ürünün fiyatını girin: ");
            giris2 = int.Parse(Console.ReadLine());
            toplam = giris + toplam + giris2;
            if (toplam >= 200)
            {
                ind = (giris2 * 25) / 100;
                ind = giris2 - ind;
                toplam = giris + ind;
                Console.WriteLine("2. ürüne yapılan %25 indirim ile ödemeniz gereken tutar: " + toplam);
            }
            else if (toplam < 200)
            {
                Console.WriteLine("Ödemeniz gereken tutar: " + toplam);
            }
            Console.ReadKey();

        }
    }
}
