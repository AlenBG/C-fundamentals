using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int firstElement = arr[0];

                int[] arr1 = new int[arr.Length];


                for (int j = 1; j < arr.Length; j++)
                {
                    arr1[j - 1] = arr[j];
                }

                arr1[arr1.Length - 1] = firstElement;
                arr = arr1;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
