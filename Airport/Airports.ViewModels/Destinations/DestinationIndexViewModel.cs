namespace Airports.ViewModels.Destinations
{
    public class DestinationIndexViewModel
    {
        public int Id { get; set; }
        public string StartAirport { get; set; }

        public string DestinationAirport { get; set; }

        public string Date { get; set; }

        public string Price { get; set; }

        public string ImageUrl { get; set; } = "https://th.bing.com/th/id/OIP.O5_QpU_yozCHwqKUz_IJlgHaEC?pid=ImgDet&rs=1";
    }
}
