namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Airport : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [InverseProperty("DestinationAirport")]
        public virtual  ICollection<FlightDestination> Destinations { get; set; }= new List<FlightDestination>();
        [InverseProperty("Airport")]
        public virtual ICollection<FlightDestination> StartDestinations { get; set; } = new List<FlightDestination>();
    }
}
