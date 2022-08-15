﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                var action = commands[0];
                var userName = commands[1];

                switch (action)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, plateNumber);
                            Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}"); 
                        }
                        break;
                    case "unregistered":
                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                          
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
