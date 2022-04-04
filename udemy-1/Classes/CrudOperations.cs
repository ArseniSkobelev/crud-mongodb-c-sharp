using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using udemy_1.DataModels;

namespace udemy_1.Classes
{
    public class CrudOperations
    {
        public static string InsertUserMethod(User userData)
        {
            Connection.ConnectionMethod<BsonDocument>(ConfigurationManager.AppSettings["collectionName"]).InsertOne(userData.ToBsonDocument());
            return "Document created succesfully!";
        }

        public static List<BsonDocument> ReadAllDocuments()
        {
            return Connection.ConnectionMethod<BsonDocument>(ConfigurationManager.AppSettings["collectionName"]).Find(new BsonDocument()).ToList();
        }
    }
}
