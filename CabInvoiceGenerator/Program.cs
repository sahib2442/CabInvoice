using System;
namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main (string[] args)
        {
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();
            double fare=cabInvoiceGenerator.CalculateFare(4.0, 8.0);
            //Ride[] ride = { new Ride(1, 2), new Ride(3, 4) };
            Console.WriteLine("Cab Fare=" +fare);
            Ride[] ride = { };
            InvoiceSummary data = GetMultipleRideFare(ride);
            Console.WriteLine(data.averageFare + "\n" + data.noOfRides);
        }

        private static InvoiceSummary GetMultipleRideFare(Ride[] ride)
        {
            throw new NotImplementedException();
        }
    }
}
