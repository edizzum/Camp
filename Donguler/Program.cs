using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazilim gelistirici yetistirme kampi";
            string Kurs2 = "Programlamaya baslangic icin temel kurs";
            string Kurs3 = "Java";
            string Kurs4 = "Python";

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi" ,
                "Programlamaya baslangic icin temel kurs",
                "Java",
                "Python"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
