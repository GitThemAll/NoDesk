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
		

		public List<BaseModel> get(string searchExpression)
		{


			List<User> users = Database.userCollectionObjs.Find(searchExpression).ToList();
			List<BaseModel> baseModels = new List<BaseModel>();
			foreach (User user in users)
			{

				baseModels.Add(user);
			}
			return baseModels;


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

			List<BaseModel> baseModels = new List<BaseModel>();
			var users = Database.userCollectionObjs.Find(new BsonDocument()).ToList();
			foreach (User user in users)
			{

				baseModels.Add(user);
			}
			return baseModels;
		}
		
		public void insert(List<BaseModel> models)
		{
			List<User> users = new List<User>();
			foreach (User model in models)
			{
				users.Add(model);
			}
			Database.userCollectionObjs.InsertMany(users);
		}
	}
}
