using Lsp.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        CreditCard card = new CreditCard();

        card.Validate();
        card.CollectPayment();

        Console.ReadKey();
    }
}