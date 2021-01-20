using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ediz";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#"; //Burada tırnak içinde yazılmasının nedeni alttaki class ta string tanımladık
            kurs1.Egitmeni = "Ediz Züm";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Barış Gül";
            kurs2.IzlenmeOrani = 10;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni = "Güney Taran";
            kurs3.IzlenmeOrani = 56;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "PHP";
            kurs4.Egitmeni = "Umut Mırrıkoğlu";
            kurs4.IzlenmeOrani = 50;

            //Console.WriteLine(kurs1.Egitmeni + " " + kurs2.IzlenmeOrani);
            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            Console.WriteLine("Hangi Eğitmen kaç izleniyor; ");
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.Egitmeni + ":" + kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}