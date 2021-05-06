using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 15;
            int sayi2 = 48;

            sayi1 = sayi2;
            sayi2 = 68;

            Console.WriteLine(sayi1 + "\n" + "*****************************");

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {40,50,60 };

            sayilar1 = sayilar2;
            sayilar2[0] = 89;
            Console.WriteLine(sayilar1[0]);


        }
    }
}
