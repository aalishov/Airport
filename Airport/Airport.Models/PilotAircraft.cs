namespace Airport.Models
{
    public class PilotAircraft
    {
        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public int PilotId { get; set; }

        public virtual Pilot Pilot { get; set; }
    }
}
