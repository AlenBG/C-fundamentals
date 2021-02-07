using System;
using System.Linq;

namespace _4._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                bool topInteger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        topInteger = false;
                        break;
                    }
                }
                if (topInteger)
                {
                    Console.Write(arr[i]+ " ");
                }
            }
            
        }
    }
}
