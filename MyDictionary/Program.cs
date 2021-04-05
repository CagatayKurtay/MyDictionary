using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(85, "Liverpool");
            dictionary.Add(80, "Manchester Utd");
            dictionary.Add(70, "Chelsea");

            Console.WriteLine(dictionary.Count);


        }
    }
}

class Dictionary<K, V>
{
    K[] AllKeys;
    V[] AllValues;

    public Dictionary()
    {
        AllKeys = new K[0];
        AllValues = new V[0];
    }

    public void Add(K key, V value)
    {
        K[] tempArrayK = AllKeys;
        V[] tempArrayV = AllValues;

        AllKeys = new K[AllKeys.Length + 1];
        AllValues = new V[AllValues.Length + 1];


        for (int i = 0; i < tempArrayK.Length; i++)
        {
            AllKeys[i] = tempArrayK[i];
        }

        for (int j = 0; j < tempArrayV.Length; j++)
        {
            AllValues[j] = tempArrayV[j];

        }

        key = AllKeys[AllKeys.Length - 1];
        value = AllValues[AllValues.Length - 1];

    }

    public int Count
    {
        get { return AllKeys.Length; }
    }
}


    
