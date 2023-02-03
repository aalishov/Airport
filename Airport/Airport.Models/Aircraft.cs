namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Aircraft : BaseModel
    {
        [Required]
        [MaxLength(25)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(30)]
        public string Model { get; set; }

        public int Year { get; set; }

        public int? FlightHours { get; set; }

        public char Condition { get; set; }

        public int TypeId { get; set; }

        public virtual AircraftType Type { get; set; }

        public virtual ICollection<PilotAircraft> PilotsAircraft { get; set; }

        public virtual ICollection<FlightDestination> FlightDestinations { get; set; }
    }
}
