using Dip_Refactored.Contracts;
using Dip_Refactored.Factory;

namespace Dip_Refactored.Payments
{
    public class PaymentProcess
    {
        public void Pay(string id)
        {
            IDbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
