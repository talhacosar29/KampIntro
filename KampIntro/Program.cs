using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int yas = 20;
            double faiz = 12.5;

            double dolarDun = 8.10;
            double dolarBugun = 8.30;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Var");
            }

            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalıs Var");
            }

            else
            {
                Console.WriteLine("Sabit");
            }

            bool sevdiMi = false;

            if (sevdiMi == true)
            {
                Console.WriteLine("Allah Ayırmasın");
            }

            else
            {
                Console.WriteLine("Canı sağolsun");
            }
        }
    }
}
