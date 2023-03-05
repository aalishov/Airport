using System;
using System.Collections.Generic;

namespace Airport.Models
{
    public class FlightDestination : BaseModel
    {
        public int AirportId { get; set; }

        public virtual Airport Airport { get; set; }

        public int DestinationAirportId { get; set; }

        public virtual Airport DestinationAirport { get; set; }

        public DateTime Start { get; set; }

        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public decimal TicketPrice { get; set; }

        public int  MaxTicketsCount { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }= new List<Reservation>();
    }
}
