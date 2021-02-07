using System;
using System.Linq;

namespace _6._of_Max_Sequence_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int sum1 = 1;
            int start = 0;
            int bestStart = 0;
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    sum1 += 1;
                }
                else
                {
                    sum1 = 1;
                    start = i;
                }

                if (sum1 > sum)
                {
                    sum = sum1;
                    bestStart = start;
                }
                
            }
            for (int i = bestStart; i < bestStart + sum; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
