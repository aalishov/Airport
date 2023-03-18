using Airport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Services
{
    public class DestinationsService
    {
        private AppDbContext context;

        public DestinationsService()
        {
            this.context= new AppDbContext();
        }
        public DestinationsService(AppDbContext context)
        {
            this.context = context;
        }


    }
}
