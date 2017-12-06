using System;

namespace Lecture21
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            Console.WriteLine("Promote logic changed.");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}