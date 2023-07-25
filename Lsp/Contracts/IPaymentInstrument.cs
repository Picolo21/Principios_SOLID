namespace Lsp.Contracts
{
    public interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
