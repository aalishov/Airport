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

                using (context = new AppDbContext())
                {
                    context.Pilots.Add(pilot);
                    context.SaveChanges();
                    msg.AppendLine($"Pilot {firstName} {lastName} is added!");
                }
            }
            return msg.ToString().TrimEnd();
        }
        
        public string GetPilotInfoById(int id)
        {
            Pilot pilot = null;
            using (context = new AppDbContext())
            {
                pilot = context.Pilots.Find(id);
            }
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

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Pilot> pilots = context.Pilots
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
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
            }



            return msg.ToString().TrimEnd();
        }

        public string UpdatePilotRating(int id, double newRating)
        {
            using (context = new AppDbContext())
            {
                Pilot pilot = context.Pilots.Find(id);
                if (pilot == null) { return $"{nameof(Pilot)} not found!"; }
                if (newRating < 0 || newRating > 10) { return "Invalid new rating!"; }
                pilot.Rating= newRating;
                context.Pilots.Update(pilot);
                context.SaveChanges();
                return $"{nameof(Pilot)} {pilot.FirstName} {pilot.LastName} has new rating: {newRating}";
            }
        }

        public string DeletePilotById(int id)
        {
            using (context = new AppDbContext())
            {
                Pilot pilot= context.Pilots.Find(id);
                if (pilot == null) { return $"{nameof(Pilot)} not found!"; }
                context.Pilots.Remove(pilot);
                context.SaveChanges();
                return $"{nameof(Pilot)} {pilot.FirstName} {pilot.LastName} was deleted!";
            }
        }
    }
}
