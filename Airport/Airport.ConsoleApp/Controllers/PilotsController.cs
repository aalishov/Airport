using Airport.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.ConsoleApp.Controllers
{

    public class PilotsController
    {
        private PilotsService service;

        public PilotsController()
        {
            service = new PilotsService();
            Run();
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    PrintMenu();
                    Console.Write("Enter command: ");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "0":
                            return;
                        case "1":
                            PilotsList();
                            break;
                        case "2":
                            AddPilot();
                            break;
                        case "3":
                            DeletePilot();
                            break;
                        case "4":
                            UpdatePilotRating();
                            break;
                        case "5":
                            GetStatistics();
                            break;
                        default:
                            Console.WriteLine("Invalid command!");
                            WaitPressKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    WaitPressKey();
                }
            }
        }

        private void GetStatistics()
        {
            string info = service.GetStatistics();
            Console.WriteLine(info);
            WaitPressKey();
        }

        private void UpdatePilotRating()
        {
            Console.Write("Enter pilot id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter pilot new rating: ");
            double rating = double.Parse(Console.ReadLine());
            string info = service.UpdatePilotRating(id, rating);
            Console.WriteLine(info);
            WaitPressKey();
        }

        private void DeletePilot()
        {
            Console.Write("Enter pilot id: ");
            int id = int.Parse(Console.ReadLine());
            string info = service.DeletePilotById(id);
            Console.WriteLine(info);
            WaitPressKey();
        }

        private void AddPilot()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter rating: ");
            double rating = double.Parse(Console.ReadLine());
            string info = service.CreatePilot(firstName, lastName, age, rating);
            Console.WriteLine(info);
            WaitPressKey();
        }

        private static void WaitPressKey()
        {
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }

        private void PilotsList()
        {
            int currentPage = 1;
            int pageCount = service.GetPilotsPagesCount();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pilots list: ");
                string info = service.GetAllPilotsInfo(currentPage);
                Console.WriteLine(info);
                Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        if (currentPage > 1) { currentPage--; }
                        break;
                    case "2":
                        if (currentPage < pageCount) { currentPage++; }
                        break;
                }
            }
        }

        public void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pilots menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Pilots list");
            sb.AppendLine($"\t2: Add pilot");
            sb.AppendLine($"\t3: Delete pilot");
            sb.AppendLine($"\t4: Update pilot info");
            sb.AppendLine($"\t5: Statistics");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
