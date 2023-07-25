using Lsp_Refactored.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        //CreditCard card = new CreditCard();
        //DebitCard card = new DebitCard();
        NubankRewards card = new NubankRewards();

        card.Validate();
        card.CollectPayment();

        Console.ReadKey();
    }
}