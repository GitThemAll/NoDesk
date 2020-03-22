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
		//todo make call async
		public static MongoClient client;
		public static IMongoDatabase database;
		public static IMongoCollection<User> userCollectionObjs;
		public static IMongoCollection<Incident> incidentCollectionObjs;
		static Database()
		{
			
			client = new MongoClient(string.Format("mongodb+srv://{0}:{1}@{2}", Settings.username, Settings.password, Settings.clusterAddress));
			database = client.GetDatabase("No_Desk");
			userCollectionObjs = database.GetCollection<User>("user");
			incidentCollectionObjs = database.GetCollection<Incident>("incident");
	
		}

	}
}
