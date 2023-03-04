using Airport.Data;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Services
{
    public class AircraftsService
    {
        private AppDbContext context;

        public string CreateAircraft(string manufacturer, string model, int year, int flightHours, string condition, string type)
        {
            AircraftType aircraftType = null;

            using (context = new AppDbContext())
            {
                aircraftType = context.AircraftTypes.FirstOrDefault(x => x.Name == type);

                if (aircraftType == null) { aircraftType = new AircraftType() { Name = type }; }

                Aircraft aircraft = new Aircraft()
                {
                    Manufacturer = manufacturer,
                    Model = model,
                    Year = year,
                    FlightHours = flightHours,
                    Type = aircraftType,
                    Condition = condition.First()
                };
                context.Aircrafts.Add(aircraft);
                context.SaveChanges();
            }
            return $"Aircraft added!";
        }

        public List<string> GetAircraftsInfo(string order = "A-Z", int page = 1, int count = 10)
        {
            List<string> aircrafts = null;
            using (context = new AppDbContext())
            {
                if (order == "A-Z")
                {
                    aircrafts = context.Aircrafts
                        .OrderBy(x => x.Manufacturer)
                        .Skip((page - 1) * count)
                        .Take(count)
                        .Select(x => $"{x.Id} - {x.Manufacturer} {x.Model}, {x.FlightHours}")
                        .ToList();
                }
                else
                {
                    aircrafts = context.Aircrafts
                        .OrderByDescending(x => x.Manufacturer)
                        .Skip((page - 1) * count)
                        .Take(count)
                        .Select(x => $"{x.Id} - {x.Manufacturer} {x.Model}, {x.FlightHours}")
                        .ToList();
                }
            }
            return aircrafts;
        }
        public int GetAircraftPagesCount(int count)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Aircrafts.Count() / (double)count);
            }
        }

        public List<string> GetManufacturersName()
        {
            using (var context = new AppDbContext())
            {
                return context.Aircrafts.Select(x => x.Manufacturer).Distinct().ToList();
            }
        }

        public List<string> GetManufacturesModels(string manufacturer)
        {
            using (var context = new AppDbContext())
            {
                return context.Aircrafts
                    .Where(x => x.Manufacturer == manufacturer)
                    .Select(x => x.Model).Distinct().ToList();
            }
        }

        public string GetModelType(string manufacturer, string model)
        {
            using (var context = new AppDbContext())
            {
                Aircraft t = context.Aircrafts
                    .Where(x => x.Manufacturer == manufacturer && x.Model == model)
                    .FirstOrDefault();
                if (t != null)
                {
                    return t.Type.Name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public List<string> GetAllModelType()
        {
            using (var context = new AppDbContext())
            {
                return context.Aircrafts
                    .Select(x => x.Type.Name).Distinct().ToList();
            }
        }
    }
}
