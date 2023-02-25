using Airport.Services;
using System;

namespace Airport.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PilotsService service = new PilotsService();

            Console.WriteLine(service.UpdatePilotRating(2,2));
        }
    }
}
