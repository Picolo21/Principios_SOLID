using Dip_Refactored.Payments;

internal class Program
{
    private static void Main(string[] args)
    {
        PaymentProcess payment = new PaymentProcess();
        payment.Pay("ABC123");

        Console.ReadKey();
    }
}