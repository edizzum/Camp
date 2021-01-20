using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]{"Ediz", "Barış", "Güney"};
            //Console.WriteLine(İsimler[0]);
            //Console.WriteLine(İsimler[1]);
            //Console.WriteLine(İsimler[2]);
            //Console.WriteLine(İsimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Hasan";
            //Console.WriteLine(isimler[4]);


            List<string> Names2 = new List<string> { "Ediz", "Barış", "Güney" };
            Console.WriteLine(Names2[0]);
            Console.WriteLine(Names2[1]);
            Console.WriteLine(Names2[2]);
            Names2.Add("İlker");
            Console.WriteLine(Names2[3]);
            Console.WriteLine(Names2[0]);
            //Names2.Add("Ediz");
        }
    }
}
