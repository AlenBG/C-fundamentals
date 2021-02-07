using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int faggons = int.Parse(Console.ReadLine());
                train[i] = faggons;
                sum += faggons;
            }
            Console.WriteLine(String.Join(' ', train));
            Console.WriteLine(sum);
        }
    }
}
