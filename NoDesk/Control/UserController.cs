using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using  MongoDB.Driver.Linq;
using Newtonsoft.Json.Linq;

namespace NoDesk
{
	class UserController : IController
	{
		public BaseModel get()
		{
			throw new NotImplementedException();
		}

		public List<BaseModel> getMany(List<BaseModel> documents, SearchMethod searchMethod)
		{
			throw new NotImplementedException();
		}

		public List<BaseModel> getAll()
		{

			List<BaseModel> users = new List<BaseModel>();
			var documents = Database.userCollection.Find(new BsonDocument()).ToList();
			foreach (var document in documents)
			{
				User user= BsonSerializer.Deserialize<User>(document);
				users.Add(user);
			}
			return users;
		}

		
		public void insert(List<BaseModel> documents)
		{
			throw new NotImplementedException();
		}
	}
}