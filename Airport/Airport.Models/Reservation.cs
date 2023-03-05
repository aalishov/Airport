using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Models
{
    public class Reservation : BaseModel
    {
        public int PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }

        public int FlightDestinationId { get; set; }

        public virtual FlightDestination FlightDestination { get; set; }

        public DateTime ReservationDate { get; set; } = DateTime.UtcNow;

        public int Tickets { get; set; }
    }
}
