using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using  MongoDB.Driver.Linq;
using Newtonsoft.Json.Linq;

namespace NoDesk
{
	class UserController 
	{


		public List<User> get(Expression<Func<User, bool>> filter)
		{
			List<User> users = Database.userCollectionObjs.Find(filter).ToList();
			return users;
		}


		public User GetLogin(string email, string password)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("email", email) & Builders<BsonDocument>.Filter.Eq("password", password);
			var document = Database.userCollection.Find(filter).First();
			User user = BsonSerializer.Deserialize<User>(document);
			return user;

		}
		public List<User> getAll()
		{
			var users = Database.userCollectionObjs.Find(new BsonDocument()).ToList();
			return users;
		}
		
		public void insert(User user)
		{
			Database.userCollectionObjs.InsertOne(user);
		}
	}
}
