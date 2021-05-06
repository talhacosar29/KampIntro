using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "C#";
            string kurs2 = "Python";
            string kurs3 = "Java";
            string kurs4 = "C";

            string[] kurslar = new string[] { "C#", "Python", "Java", "C" };

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("***************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
