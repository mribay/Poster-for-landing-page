using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Poster_for_landing_page
{
    public class MongoCRUD
    {
        private MongoClient dbClient;
        private string dbDatabaseString;
        private string dbCollectionString;

        public List<BsonDocument> ReadResult;


        public MongoCRUD(string client, string database, string collection)
        {
            dbClient = new MongoClient(client);
            dbDatabaseString = database;
            dbCollectionString = collection;
        }

        public void Create(BsonDocument data)
        {
            var database = dbClient.GetDatabase(dbDatabaseString);
            var collection = database.GetCollection<BsonDocument>(dbCollectionString);

            collection.InsertOne(data);
        }

        public void Read()
        {
            var database = dbClient.GetDatabase(dbDatabaseString);
            var collection = database.GetCollection<BsonDocument>(dbCollectionString);
            var documents = collection.Find(new BsonDocument()).ToList();

            ReadResult = documents;
        }

        public void Update(string id, string updateThe, string updateTo)
        {
            var database = dbClient.GetDatabase(dbDatabaseString);
            var collection = database.GetCollection<BsonDocument>(dbCollectionString);

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var update = Builders<BsonDocument>.Update.Set(updateThe, updateTo);

            collection.UpdateOne(filter, update);
        }

        public void Delete(string id)
        {
            var database = dbClient.GetDatabase(dbDatabaseString);
            var collection = database.GetCollection<BsonDocument>(dbCollectionString);

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            collection.DeleteOne(filter);
        }

    }
}
