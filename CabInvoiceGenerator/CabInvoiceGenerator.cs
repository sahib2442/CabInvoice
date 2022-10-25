using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceGenerator
    {
        // uc1
        private static readonly double COST_PER_KILOMETER = 10.0;
        private static readonly double COST_PER_MINUTE = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double cabFare = 0.0;
        private RideRepository rideRepository = new RideRepository();
        public double CalculateFare(double distance, double time)
        {
            this.cabFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            return Math.Max(this.cabFare, MINIMUM_FARE);
            Console.WriteLine("Cab Fare=" + cabFare);
        }
        //uc2
        public InvoiceSummary GetMultipleRideFare(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare += this.CalculateFare(ride.rideDistance, ride.rideTime);
            }
            return new InvoiceSummary(totalRideFare, rides.Length);
            Ride[] ride = { };
            InvoiceSummary data = GetMultipleRideFare(ride);
            Console.WriteLine(data.averageFare + "\n" + data.noOfRides);
        }
        public void MapRidesToUser(string userID, Ride[] rides)
        {
            this.rideRepository.AddCabRides(userID, rides);
        }
        public InvoiceSummary GetInvoiceSummary(string userID)
        {
            return this.GetMultipleRideFare(this.rideRepository.GetCabRides(userID));
        }
    }
}
    }
}

       