namespace Lsp_Refactored.Contracts
{
    public interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
