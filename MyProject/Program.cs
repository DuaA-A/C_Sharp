﻿using System;

namespace challengeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // bool flag = true;
            // int value = 0;
            // if (flag)
            //     Console.WriteLine($"Inside the code block: {value}");
            // value = 10;
            // Console.WriteLine($"Outside the code block: {value}");
            //------------------------------
            //Variable scope challenge
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
                int total=0;
                bool found=false;
            foreach (int number in numbers){
                total += number;
                if (number == 42)
                    found = true;
            }
            if (found) 
                Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");
        }
    }
}