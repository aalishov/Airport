using Airport.Data;
using Airport.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Services
{
    public class AircraftsService
    {
        private AppDbContext context;

        public string AddCabinCrew(int aircraftId, List<int> cabinCrewId)
        {

            StringBuilder message = new StringBuilder();
            using (context = new AppDbContext())
            {
                Aircraft aircraft = context.Aircrafts.Find(aircraftId);
                if (aircraft == null)
                {
                    message.AppendLine($"{nameof(Aircraft)} not found!");
                    return message.ToString().TrimEnd();
                };
                List<Pilot> pilots = new List<Pilot>();
                foreach (var id in cabinCrewId)
                {
                    Pilot pilot = context.Pilots.Find(id);
                    if (pilot != null)
                    {
                        pilots.Add(pilot);
                    }
                }
                if (pilots.Count == 0)
                {
                    message.AppendLine($"{nameof(Pilot)}s not found!");
                    return message.ToString().TrimEnd();
                }
                message.AppendLine($"{aircraftId} {aircraft.Manufacturer} {aircraft.Model} cabin crew: ");
                foreach (var pilot in pilots)
                {
                    context.PilotsAircraft.Add(new PilotAircraft
                    {
                        Aircraft = aircraft,
                        Pilot = pilot
                    });
                    message.AppendLine($"\t{pilot.FirstName} {pilot.LastName}");
                }
                context.SaveChanges();
                return message.ToString().TrimEnd();
            }
        }

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

        public List<string> GetAircraftsInfoWithoutCrew( int page = 1, int count = 10)
        {
            List<string> aircrafts = null;
            using (context = new AppDbContext())
            {
                
                    aircrafts = context.Aircrafts
                        .Where(x=>!x.PilotsAircraft.Any())
                        .Skip((page - 1) * count)
                        .Take(count)
                        .Select(x => $"{x.Id} - {x.Manufacturer} {x.Model}, {x.FlightHours}")
                        .ToList();
            }
            return aircrafts;
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

        public int GetAircraftWithoutCrewPagesCount(int count=10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Aircrafts.Where(x=>!x.PilotsAircraft.Any()).Count() / (double)count);
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
