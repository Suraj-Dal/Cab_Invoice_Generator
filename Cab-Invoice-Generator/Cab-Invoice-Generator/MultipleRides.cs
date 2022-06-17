using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    internal class MultipleRides
    {
        public Dictionary<string, double> rides = new Dictionary<string, double>();
        InvoiceGenerator generate = new InvoiceGenerator();
        double fare = 0;
        public void calculateMultipleFare(double distance, double time)
        {
            Console.WriteLine("Enter Ride ID:");
            string id = Console.ReadLine();
            double fare = generate.calculateFare(distance, time);
            this.rides.Add(id, fare);
        }
        public void calculateAggregate()
        {
            int count = 0;
            foreach (var value in this.rides.Values)
            {
                fare = fare + value;
                count++;
            }
            double aggregate = fare / count;
            Console.WriteLine("Aggregate for all rides is:"+ aggregate);
        }
    }
}
