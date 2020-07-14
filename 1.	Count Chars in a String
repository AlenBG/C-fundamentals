using System;
using System.Collections.Generic;

namespace Exercise_Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == ' ')
                {
                    continue;
                }
                else if (dictionary.ContainsKey(word[i]))
                {
                    dictionary[word[i]]++;
                }
                else
                {
                    dictionary.Add(word[i], 1);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
