using Airports.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.ViewModels.Destinations
{
    public    class DestinationsSeacrhViewModel : PagingViewModel
    {
        public List<DestinationIndexViewModel> Destinations { get; set; } = new List<DestinationIndexViewModel>();

        public int Min { get; set; }

        public int Max { get; set; }
    }
}
