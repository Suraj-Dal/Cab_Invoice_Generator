Cab_Invoice_Generator.InvoiceGenerator ig = new Cab_Invoice_Generator.InvoiceGenerator();
Console.WriteLine("Enter Distance:");
double dist = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Time:");
double time = Convert.ToDouble(Console.ReadLine());
ig.calculateFare(dist, time);