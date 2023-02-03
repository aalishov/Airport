using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Airport.Models
{
    public class Airport
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string AirportName { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }
    }
}
