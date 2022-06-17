using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        int COST_PER_KM = 10, COST_PER_MIN = 1, MIN_FARE = 5;
        double Fare;
        
        public double calculateFare(double distance, double time)
        {
            try
            {
                Fare = (COST_PER_KM * distance) + (COST_PER_MIN * time);
            }
            catch(ExceptionHandler)
            {
                if (distance <= 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_DISTAANCE, "Invalid Distance");
                if (time < 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(Fare, MIN_FARE);
        }
    }
}
