namespace Lsp.Entities
{
    public class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificando o saldo da conta...");
            Console.WriteLine("Saldo disponível!");
        }
    }
}
