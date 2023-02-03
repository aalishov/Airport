using System;

namespace Airport.Models
{
    public class FlightDestination : BaseModel
    {
        public int AirportId { get; set; }

        public virtual Airport Airport { get; set; }

        public DateTime Start { get; set; }

        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public int PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

        public decimal TicketPrice { get; set; }
    }
}
