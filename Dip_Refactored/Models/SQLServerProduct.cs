using Dip_Refactored.Contracts;

namespace Dip_Refactored.Models
{
    public class SQLServerProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo os dados do produto {id}.";
        }
    }
}
