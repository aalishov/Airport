using Airport.Data;
using Airport.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Services
{
    public class AirportsService
    {
        private AppDbContext context;

        public string CreateAirport(string name, string country)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                sb.AppendLine($"{nameof(Airport)} invalid name!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(country))
            {
                sb.AppendLine($"{nameof(Airport)} invalid country name!");
                isValid = false;
            }
            if (isValid)
            {
                Models.Airport airport = new Models.Airport()
                {
                    Name = name,
                    Country = country,
                };
                using (context = new AppDbContext())
                {
                    context.Airports.Add(airport);
                    context.SaveChanges();
                    sb.AppendLine($"Airport added!");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public List<Models.Airport> GetAirports(string country = "", int page = 1, int count = 10)
        {
            using (context = new AppDbContext())
            {
                return context.Airports.Skip((page - 1) * count)
                    .Where(x => string.IsNullOrEmpty(country) ? x.Id != -1 : x.Country.StartsWith(country))
                    .Take(count)
                    .ToList();
            }
        }

        public int AirportsTotalPage(string country = "",int count=10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling((decimal)context.Airports
                    .Where(x => string.IsNullOrEmpty(country) ? x.Id != -1 : x.Country.StartsWith(country))
                    .Count() / count);
            }
        }

        public string UpdateAirport(int id, string name, string country)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;
            using (context = new AppDbContext())
            {
                Models.Airport airport = context.Airports.Find(id);
                if (airport == null)
                {
                    sb.AppendLine($"{nameof(Airport)} with id: {id} not found!");
                    isValid = false;
                }
                if (string.IsNullOrWhiteSpace(name))
                {
                    sb.AppendLine($"{nameof(Airport)} invalid name!");
                    isValid = false;
                }
                if (string.IsNullOrWhiteSpace(country))
                {
                    sb.AppendLine($"{nameof(Airport)} invalid country name!");
                    isValid = false;
                }
                if (isValid)
                {
                    airport.Name= name;
                    airport.Country= country;
                    context.Airports.Update(airport);
                    context.SaveChanges();
                    sb.AppendLine($"Airport updated!");
                }
            }
            return sb.ToString().TrimEnd();
        }
        public string DeleteAirport(int id)
        {
            using (context = new AppDbContext())
            {
                Models.Airport airport = context.Airports.Find(id);
                if (airport == null)
                {
                    return $"{nameof(Airport)} with id: {id} not found!";
                }

                context.Airports.Remove(airport);
                context.SaveChanges();
                return $"{nameof(Airport)} with id: {id} is deleted!";
            }
        }
    }
}
