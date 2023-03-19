using Airport.Data;
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

        public DestinationsIndexViewModel GetDestinations(DestinationsIndexViewModel model)
        {
            model.Destinations = context.FlightDestinations
                .Skip((model.PageNumber - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new DestinationIndexViewModel() 
                {
                    Id=x.Id,
                    StartAirport=$"{x.Airport.Name} {x.Airport.Country}",
                    DestinationAirport= $"{x.DestinationAirport.Name} {x.DestinationAirport.Country}",
                    Date=x.Start.ToShortDateString() ,
                    Price=x.TicketPrice.ToString()
                })
                .ToList();

            model.ElementsCount= context.FlightDestinations.Count();

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
