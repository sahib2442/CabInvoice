namespace CabInvoiceGenerator
{
    public class Ride
    {
        internal double rideDistance;
        internal double rideTime;
        private int v1;
        private int v2;

        public Ride(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}