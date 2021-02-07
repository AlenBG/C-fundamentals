using System;
using System.Linq;
using System.Collections.Generic;
namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] command2 = command.Split();
                if (command2[0] == "Delete")
                {
                    
                    int num = int.Parse(command2[1]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] == num)
                        {
                            wagon.RemoveAt(i);
                        }
                    }
                }
                else if (command2[0] == "Insert")
                {
                    int num1 = int.Parse(command2[1]);
                    int num2 = int.Parse(command2[2]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if(i == num2)
                        {
                            wagon.Insert(i, num1);
                        }
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', wagon));
        }
    }
}
