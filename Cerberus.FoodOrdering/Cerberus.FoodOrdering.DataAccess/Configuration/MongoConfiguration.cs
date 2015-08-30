using System.Configuration;

namespace Cerberus.FoodOrdering.DataAccess.Configuration
{
    public class MongoConfiguration : IMongoConfiguration
    {
        public string DatabaseName => ConfigurationManager.AppSettings["mongodb:databaseName"];
        public string Username => ConfigurationManager.AppSettings["mongodb:username"];
        public string Password => ConfigurationManager.AppSettings["mongodb:password"];
        public string Host => ConfigurationManager.AppSettings["mongodb:host"];
        public int Port => int.Parse(ConfigurationManager.AppSettings["mongodb:port"]);
    }
}