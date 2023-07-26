using Dip_Refactored.Contracts;
using Dip_Refactored.Models;
using System.Configuration;

namespace Dip_Refactored.Factory
{
    public class DbProductFactory
    {
        public static IDbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
    }
}
