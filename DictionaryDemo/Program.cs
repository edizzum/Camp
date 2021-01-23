using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> newdict = new Dictionary<string, string>();//example of how dictionaries work and their features.
            newdict.Add("City", "Şehir");
            newdict.Add("Town", "Kasaba");
            foreach (KeyValuePair<string, string> item in newdict)
            {
                Console.WriteLine(item.Key);
            }
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>(); //example of using my method
            myDictionary.Add("Key", "Anahtar");
            myDictionary.Add("Value", "Değer");
            myDictionary.Add("Item", "Esya");
            myDictionary.Add("Dictionary", "Sozluk");
            myDictionary.Add("Add", "Ekle");
            myDictionary.Add("Main", "Ana");
            myDictionary.PrintDict(1);
            myDictionary.PrintDict(2);
            myDictionary.PrintDict(3);
            myDictionary.PrintDict(4);
            myDictionary.PrintDict(5);
            myDictionary.PrintDict(6);
            myDictionary.PrintKeys();
            myDictionary.PrintValues();
        }
    }
}
