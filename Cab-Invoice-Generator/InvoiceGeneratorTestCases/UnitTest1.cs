namespace InvoiceGeneratorTestCases
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTimeCalculateAndReturnTotalFare()
        {
            double distance = 2, time = 5, expected = 25;
            Cab_Invoice_Generator.InvoiceGenerator generate = new Cab_Invoice_Generator.InvoiceGenerator();
            double result = generate.calculateFare(distance, time);
            Assert.AreEqual(expected, result);
        }
    }
}