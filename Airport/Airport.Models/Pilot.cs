namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Pilot : BaseModel
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public double? Rating { get; set; }

        public virtual ICollection<PilotAircraft> PilotsAircraft { get; set; }
    }
}
