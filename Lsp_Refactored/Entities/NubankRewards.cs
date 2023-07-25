using Lsp_Refactored.Contracts;

namespace Lsp_Refactored.Entities
{
    internal class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK, Rewards OK!");
        }
    }
}
