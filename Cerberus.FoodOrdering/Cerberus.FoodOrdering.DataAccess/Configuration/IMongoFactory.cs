using MongoDB.Driver;

namespace Cerberus.FoodOrdering.DataAccess.Configuration
{
    public interface IMongoFactory
    {
        IMongoDatabase GetMongoDatabase();
    }
}