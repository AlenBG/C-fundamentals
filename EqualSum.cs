using System;
using System.Linq;

namespace Array_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(arr.Length <= 1)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                int sum1 = 0;
                if (i >= 1)
                {
                    for (int j = i - 1 ; j >= 0; j--)
                    {
                        sum += arr[j];
                    }

                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        sum1 += arr[k];
                    }
                    if(sum == sum1)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                
            }
            Console.WriteLine("no");
        }
    }
}
