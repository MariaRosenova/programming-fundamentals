﻿using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStart = int.Parse(Console.ReadLine());
            int numberEnd = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = numberStart; i <= numberEnd; i++)
            {
                sum += i;
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
