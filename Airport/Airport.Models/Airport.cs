﻿namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Airport : BaseModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public virtual ICollection<FlightDestination> FlightDestinations { get; set; }
    }
}
