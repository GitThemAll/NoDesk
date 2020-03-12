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
		public User GetLogin(string email, string password)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("email", email) & Builders<BsonDocument>.Filter.Eq("password", password);
			var document = Database.userCollection.Find(filter).First();
			/*User user = new User()
			{
				firstname = document.GetValue(1).ToString(),
				lastname = document.GetValue(2).ToString(),
				email = document.GetValue(3).ToString()
			};*/
			User user = BsonSerializer.Deserialize<User>(document);
			return user;
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