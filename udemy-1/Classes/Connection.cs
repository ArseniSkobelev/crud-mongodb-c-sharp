using MongoDB.Driver;
using System.Configuration;

namespace udemy_1.Classes
{
    public class Connection
    {
        public static IMongoCollection<T> ConnectionMethod<T>(in string collection)
        {
            var mongoDBUri = ConfigurationManager.AppSettings["uri"];
            MongoClient dbClient = new MongoClient(mongoDBUri);
            var database = dbClient.GetDatabase(ConfigurationManager.AppSettings["dbName"]);
            return database.GetCollection<T>(ConfigurationManager.AppSettings["collectionName"]);
        }
    }
}
