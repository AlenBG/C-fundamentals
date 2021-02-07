using System;

namespace _1._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            n -= 1;
            if (n >=0 && n <= 6)
            {
                Console.WriteLine(day[n]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
