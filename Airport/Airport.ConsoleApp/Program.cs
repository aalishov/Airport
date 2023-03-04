using Airport.Services;
using System;
using System.Collections.Generic;

namespace Airport.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AircraftsService service = new AircraftsService();

            int aircraftId = 101;
            List<int> pilots = new List<int>() { 2, 4, 6, 12 };
            string result = service.AddCabinCrew(aircraftId, pilots);
            Console.WriteLine(result);
        }
    }
}
