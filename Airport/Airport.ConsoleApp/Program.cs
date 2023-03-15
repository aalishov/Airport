using Airport.ConsoleApp.Controllers;
using Airport.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Enter command: ");
                string cmd=Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        new PilotsController();
                        break;
                    default:
                        Console.WriteLine("Invalid command!"); 
                        break;
                }
            }
        }
        public static void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pilots menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Pilots");
            sb.AppendLine($"\t2: Airports");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
