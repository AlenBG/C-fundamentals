using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> material = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while(command != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (material.ContainsKey(command))
                {
                    material[command] += quantity; 
                }
                else
                {
                    material.Add(command, quantity);
                }
                command = Console.ReadLine();
            }
            foreach (var item in material)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
