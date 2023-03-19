using Airport.Data;
using Airport.Models;
using Airports.ViewModels.Destinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Services
{
    public class DestinationsService
    {
        private AppDbContext context;

        public DestinationsService()
        {
            this.context = new AppDbContext();
        }
        public DestinationsService(AppDbContext context)
        {
            this.context = context;
        }

        public List<string> GetFromAirports()
        {
            return this.context.Airports.
                OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Name}")
                .ToList();
        }
        public List<string> GetToAirports(int fromAirportId)
        {
            return this.context.Airports
                .Where(x => x.Id != fromAirportId)
                 .OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Name}").ToList();
        }
        public List<string> GetAircrafts()
        {
            return this.context.Aircrafts
                 .OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Manufacturer} {x.Model}").ToList();
        }

        public string CreateDestination(int fromAirportId, int toAirportId, DateTime flightDate, int aircraftId, decimal ticketPrice, int ticketsCount)
        {
            FlightDestination destination = new FlightDestination()
            {
                AircraftId = aircraftId,
                DestinationAirportId = toAirportId,
                Start = flightDate,
                AirportId = fromAirportId,
                TicketPrice = ticketPrice,
                MaxTicketsCount = ticketsCount
            };

            context.FlightDestinations.Add(destination);
            context.SaveChanges();

            return "Destination created!";
        }
        public DestinationsIndexViewModel GetDestinations(DestinationsIndexViewModel model)
        {
            model.Destinations = context.FlightDestinations
                .Skip((model.PageNumber - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new DestinationIndexViewModel()
                {
                    Id = x.Id,
                    StartAirport = $"{x.Airport.Name} {x.Airport.Country}",
                    DestinationAirport = $"{x.DestinationAirport.Name} {x.DestinationAirport.Country}",
                    Date = x.Start.ToShortDateString(),
                    Price = x.TicketPrice.ToString()
                })
                .ToList();

            model.ElementsCount = context.FlightDestinations.Count();

            return model;
        }

        public List<DestinationIndexViewModel> GetChepestDestinations()
        {
            return context.FlightDestinations.OrderBy(x => x.TicketPrice)
                .Take(9)
                .Select(x => new DestinationIndexViewModel()
                {
                    Id = x.Id,
                    StartAirport = $"{x.Airport.Name} {x.Airport.Country}",
                    DestinationAirport = $"{x.DestinationAirport.Name} {x.DestinationAirport.Country}",
                    Date = x.Start.ToShortDateString(),
                    Price = x.TicketPrice.ToString()
                })
                .ToList();
        }
        public List<DestinationIndexViewModel> GetMostExpensiveDestinations()
        {
            return context.FlightDestinations.OrderByDescending(x => x.TicketPrice)
                .Take(9)
                .Select(x => new DestinationIndexViewModel()
                {
                    Id = x.Id,
                    StartAirport = $"{x.Airport.Name} {x.Airport.Country}",
                    DestinationAirport = $"{x.DestinationAirport.Name} {x.DestinationAirport.Country}",
                    Date = x.Start.ToShortDateString(),
                    Price = x.TicketPrice.ToString()
                })
                .ToList();
        }
    }
}
