using System;

namespace matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik.DortIslem dortIslem = new Matematik.DortIslem();

            Console.Write("Sonuç: ");
            dortIslem.Topla(5, 6);

            Console.Write("Sonuç: ");
            dortIslem.Topla(6, 9);
        }
    }
}