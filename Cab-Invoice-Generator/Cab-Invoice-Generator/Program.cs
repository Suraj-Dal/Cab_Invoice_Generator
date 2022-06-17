Cab_Invoice_Generator.MultipleRides multiride = new Cab_Invoice_Generator.MultipleRides();
Console.WriteLine("How many rides you want to take:");
int rides = Convert.ToInt32(Console.ReadLine());
while (rides != 0)
{
    Console.WriteLine("Enter Distance:");
    double dist = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Time:");
    double time = Convert.ToDouble(Console.ReadLine());
    multiride.calculateMultipleFare(dist, time);
    rides--;
}
multiride.calculateAggregate();
