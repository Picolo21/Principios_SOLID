namespace Dip.Models
{
    public class SQLServerProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo os dados do produto {id}.";
        }
    }
}
