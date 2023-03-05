using Airport.Services;
using System;
using System.Collections.Generic;

namespace Airport.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DestinationsService service = new DestinationsService();

            service.ChangeDb();
        }
    }
}
