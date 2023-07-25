using Lsp.Contracts;

namespace Lsp.Entities
{
    public abstract class NubankCard : IPaymentInstrument
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
