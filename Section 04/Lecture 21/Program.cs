using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Lecture21
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            var rating = this.CalculateRating(excludeOrders: true);
            
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}