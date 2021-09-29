﻿using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
       // public delegate Action act;
        public static int sec = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("1 - first task (timer)");
            Console.WriteLine("2 - second task (calculate)");
            int m = Convert.ToInt32(Console.ReadLine());
            switch(m)
            { 
                case 1:
                    Timer timer = new Timer(() => Console.WriteLine("///"), 2);
                    timer.Start();
                    timer.Stop();
                    timer.Start();
                    timer.Restart();
                break;
               
                case 2:
                    Counter counter = new Counter();
                    int sum = counter.Calculate();
                    Console.WriteLine();
                    Console.WriteLine("Sum in all threads = " + sum);
                    break;
            }
        }

    }
}
