using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(double number1, double number2)
        {
            double toplam = number1 + number2;
            Console.WriteLine(toplam);
        }
        public void Çıkarma(double number1, double number2)
        {
            double Çıkarma = number1 - number2;
            Console.WriteLine(Çıkarma);
        }
        public void Bölme(double number1, double number2)
        {
            double Bölme = number1 / number2;
            Console.WriteLine(Bölme);
        }
        public void Çarpma(double number1, double number2)
        {
            double Çarpma = number1 * number2;
            Console.WriteLine(Çarpma);
        }
    }
}