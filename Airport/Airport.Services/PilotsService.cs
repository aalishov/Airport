namespace Airport.Services
{
    using Data;
    using Models;
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class PilotsService
    {
        private AppDbContext context;
        public PilotsService() { context = new AppDbContext(); }

        public PilotsService(AppDbContext context) { this.context = context; }

        public string CreatePilot(string firstName, string lastName, int age, double rating)
        {
            StringBuilder msg = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                msg.AppendLine($"Invalid {nameof(firstName)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                msg.AppendLine($"Invalid {nameof(lastName)}!");
                isValid = false;
            }
            if (age < 18 || age > 65)
            {
                msg.AppendLine($"Invalid {nameof(age)}!");
                isValid = false;
            }
            if (rating < 0.0 || rating > 10.0)
            {

                msg.AppendLine($"Invalid {nameof(rating)}!");
                isValid = false;
            }

            if (isValid)
            {
                Pilot pilot = new Pilot()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Rating = rating
                };

                using (context = context ?? new AppDbContext())
                {
                    context.Pilots.Add(pilot);
                    context.SaveChanges();
                    msg.AppendLine($"Pilot {firstName} {lastName} is added!");
                }
            }
            return msg.ToString().TrimEnd();
        }

        public Pilot GetPilotById(int id)
        {
            
                return context.Pilots.FirstOrDefault(x => x.Id == id);
            
        }

        public string GetStatistics()
        {
            StringBuilder msg = new StringBuilder();
            string line = new string('-', 30);
           
                msg.AppendLine(line);
                msg.AppendLine($"Pilots count: {context.Pilots.Count()}");
                msg.AppendLine(line);
                msg.AppendLine($"Average age: {context.Pilots.Average(x => x.Age):f2}");
                msg.AppendLine(line);
                msg.AppendLine($"Average rating: {context.Pilots.Average(x => x.Rating):f2}");

                List<Pilot> topPilots = context.Pilots.OrderByDescending(x => x.Rating).Take(10).ToList();
                List<Pilot> botPilots = context.Pilots.OrderBy(x => x.Rating).Take(10).ToList();
                msg.AppendLine(line);
                msg.AppendLine($"Top pilots: ");
                topPilots.ForEach(x => msg.AppendLine($"\t{x.FirstName} {x.LastName}"));
                msg.AppendLine(line);
                msg.AppendLine($"Bottom pilots: ");
                botPilots.ForEach(x => msg.AppendLine($"\t{x.FirstName} {x.LastName}"));
               msg.AppendLine(line);
            
            return msg.ToString();
        }

        public string GetPilotInfoById(int id)
        {
            Pilot pilot = null;
            
                pilot = context.Pilots.Find(id);
            
            if (pilot != null)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine($"{nameof(Pilot)} info: ");
                msg.AppendLine($"\tId: {pilot.Id}");
                msg.AppendLine($"\tFirst name: {pilot.FirstName}");
                msg.AppendLine($"\tLast name: {pilot.LastName}");
                msg.AppendLine($"\tAge: {pilot.Age}");
                msg.AppendLine($"\tRating: {pilot.Rating}");
                return msg.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Pilot)} not found!";
            }
        }

        public string GetAllPilotsInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Age",-3} | {"Rating",-6}|";

            string line = GetLine(firstRow.Length);


            List<Pilot> pilots = context.Pilots
                .Skip((page - 1) * count)
                .Take(count)
                .ToList();
            msg.AppendLine(GetLine(firstRow.Length));
            msg.AppendLine(firstRow);
            msg.AppendLine(line);
            foreach (var p in pilots)
            {
                string info = $"| {p.Id,-4} | {p.FirstName,-12} | {p.LastName,-12} | {p.Age,-3} | {p.Rating,-6}|";
                msg.AppendLine(info);
                msg.AppendLine(line);
            }
            int pageCount = (int)Math.Ceiling(context.Pilots.Count() / (decimal)count);
            msg.AppendLine($"Page: {page} / {pageCount}");

            return msg.ToString().TrimEnd();
        }

        private static string GetLine(int length, char c = '|')
        {
            return $"{c}{new string('-', length - 2)}{c}";
        }

        public List<string> GetPilotsBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;

            list = context.Pilots
                .Skip((page - 1) * count)
                .Take(count)
                .Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
               .ToList();

            return list;
        }

        public int GetPilotsPagesCount(int count = 10)
        {
            return (int)Math.Ceiling(context.Pilots.Count() / (double)count);
        }


        public int GetPilotsCount()
        {
            return context.Pilots.Count();
        }

        public string UpdatePilotRating(int id, double newRating)
        {
            Pilot pilot = context.Pilots.Find(id);
            if (pilot == null) { return $"{nameof(Pilot)} not found!"; }
            if (newRating < 0 || newRating > 10) { return "Invalid new rating!"; }
            pilot.Rating = newRating;
            context.Pilots.Update(pilot);
            context.SaveChanges();
            return $"{nameof(Pilot)} {pilot.FirstName} {pilot.LastName} has new rating: {newRating}";

        }

        public string DeletePilotById(int id)
        {
            Pilot pilot = context.Pilots.FirstOrDefault(x => x.Id == id);
            if (pilot == null) { return $"{nameof(Pilot)} not found!"; }
            context.Pilots.Remove(pilot);
            context.SaveChanges();
            return $"{nameof(Pilot)} {pilot.FirstName} {pilot.LastName} was deleted!";
        }
    }
}
