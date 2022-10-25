using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        private Dictionary<string, List<Ride>> userRideList = new Dictionary<string, List<Ride>>();
        public void AddCabRides(string userID, Ride[] ride)
        {
            bool checkList = this.userRideList.ContainsKey(userID);
            if (checkList == false)
            {
                this.userRideList.Add(userID, new List<Ride>(ride));
            }
        }
        public Ride[] GetCabRides(string userId)
        {
            return this.userRideList[userId].ToArray();
        }
    }
}