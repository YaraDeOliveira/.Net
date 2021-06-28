using System;
using System.Collections.Generic;
using System.Text;

namespace LocadoraCarros.Entities
{
    class CarRental
    {
        
        public DateTime Pickup { get; set; }
        public DateTime Return { get; set; }

        public Vehicle Vehicle { get; set; }
   
        public Invoice Invoice { get; set; }

        public CarRental(DateTime pickup, DateTime @return, Vehicle vehicle)
        {
            Pickup = pickup;
            Return = @return;
            Vehicle = vehicle;
            Invoice = null;
        }

    
    }
}
