namespace Airport.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class AircraftType : BaseModel
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();
    }
}
