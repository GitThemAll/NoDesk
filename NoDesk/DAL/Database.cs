using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NoDesk
{
	public static class Database
	{
		public static MongoClient client;
		public static IMongoDatabase database;
		public static IMongoCollection<BsonDocument> userCollection;
		public static IMongoCollection<BsonDocument> incidentCollection;
		static Database()
		{
			
			client = new MongoClient(string.Format("mongodb+srv://{0}:{1}@{2}", Settings.username, Settings.password, Settings.clusterAddress));
			database = client.GetDatabase("No_Desk");
			userCollection = database.GetCollection<BsonDocument>("user");
			incidentCollection = database.GetCollection<BsonDocument>("incident");
		}


	}
}
