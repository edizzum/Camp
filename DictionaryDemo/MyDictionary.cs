using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1, T2>
    {
        T1[] newDictKey;
        T1[] tempDictKey;
        T2[] newDictValue;
        T2[] tempDictValue;

        public MyDictionary()
        {
            newDictKey = new T1[1];
            newDictValue = new T2[1];
        }

        public void Add(T1 key, T2 value)
        {
            tempDictKey = newDictKey;
            newDictKey = new T1[newDictKey.Length + 1];
            tempDictValue = newDictValue;
            newDictValue = new T2[tempDictValue.Length + 1];

            for (int i = 0; i < tempDictKey.Length; i++)
            {
                newDictKey[i] = tempDictKey[i];
            }
            for (int i = 0; i < tempDictValue.Length; i++)
            {
                newDictValue[i] = tempDictValue[i];
            }
            newDictKey[newDictKey.Length - 1] = key;
            newDictValue[newDictValue.Length - 1] = value;
        }
        public void PrintDict(int index)
        {
            Console.WriteLine(newDictKey[index - 1] + " : " + newDictValue[index - 1]);
        }
        public void PrintKeys()
        {
            foreach (var key in newDictKey)
            {
                Console.WriteLine(key);
            }
        }
        public void PrintValues()
        {
            foreach (var value in newDictValue)
            {
                Console.WriteLine(value);
            }
        }
    }
}