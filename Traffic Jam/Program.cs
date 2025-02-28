﻿using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carThatCanPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            
            string command = Console.ReadLine();
            int passedCount = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carThatCanPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            passedCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
