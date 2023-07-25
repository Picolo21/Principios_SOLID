namespace Lsp_Refactored.Entities
{
    public abstract class NubankCard
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
        }
    }
}
