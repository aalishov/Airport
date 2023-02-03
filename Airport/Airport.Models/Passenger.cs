namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Passenger : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        public virtual ICollection<FlightDestination> FlightDestinations { get; set; }
    }
}
