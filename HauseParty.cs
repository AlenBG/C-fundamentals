using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command.Count == 3)
                {
                    string name = command[0];
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    string name1 = command[0];
                    if (names.Contains(name1))
                    {
                        names.Remove(name1);
                    }
                    else
                    {
                        Console.WriteLine($"{name1} is not in the list!");
                    }
                }

            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
