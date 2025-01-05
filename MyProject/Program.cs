using System;

namespace challengeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            bool flag = true;
            int value = 0;
            if (flag)
                Console.WriteLine($"Inside the code block: {value}");
            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }
    }
}