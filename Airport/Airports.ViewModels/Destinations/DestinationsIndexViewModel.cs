using Airports.ViewModels.Destinations;
using Airports.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.ViewModels.Destinations
{
    public class DestinationsIndexViewModel : PagingViewModel
    {
        public List<DestinationIndexViewModel> Destinations { get; set; }= new List<DestinationIndexViewModel>();
    }
}
