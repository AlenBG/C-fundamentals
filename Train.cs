using System;
using System.Linq;
using System.Collections.Generic;
namespace list_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] elements = command.Split();
                if(elements[0] == "Add")
                {
                    int num1 = int.Parse(elements[1]);
                    wagon.Add(num1);
                }
                else
                {
                    int num = int.Parse(elements[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (num + wagon[i] <= maxCapacity)
                        {
                            wagon[i] += num;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', wagon));
        }
    }
}
