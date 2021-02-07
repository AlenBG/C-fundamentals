using System;
using System.Collections.Generic;
using System.Linq;

namespace arrays123
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            foreach (var item in array)
            {
                if (numbers.ContainsKey(item))
                {
                    numbers[item]++;
                }
                else
                {
                    numbers.Add(item, 1);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
