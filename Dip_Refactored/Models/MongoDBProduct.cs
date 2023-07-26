using Dip_Refactored.Contracts;

namespace Dip_Refactored.Models
{
    public class MongoDBProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Exibindo os dados do produto {id}.";
        }
    }
}
