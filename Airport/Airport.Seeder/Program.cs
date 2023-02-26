using Airport.Services;
using System;
using System.Collections.Generic;

namespace Airport.Seeder
{
    public class Program
    {
        private static PilotsService pilotService = new PilotsService();  
        public static void Main()
        {
            SeedPilots(100);
        }

        public static void SeedPilots(int pilotsCount)
        {
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel" };

            Random random= new Random();

            for (int i = 0; i < pilotsCount; i++)
            {
                int pilotFirstName = random.Next(0, firstName.Count);
                int pilotLastName = random.Next(0, lastName.Count);
                double rating = Math.Round(random.NextDouble() * random.Next(1, 9), 1);
                int age = random.Next(18, 60);
                Console.WriteLine(pilotService.CreatePilot(firstName[pilotFirstName], lastName[pilotLastName], age, rating));
            }
        }
    }
}
