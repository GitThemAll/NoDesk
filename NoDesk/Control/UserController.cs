using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Newtonsoft.Json.Linq;

namespace NoDesk
{
	class UserController 
	{
		//todo make all  methods async.
		private List<User> allUsers;
		public List<User> get(Expression<Func<User, bool>> filter)
		{
			List<User> users = Database.userCollectionObjs.Find(filter).ToList();
			return users;
		}

		public List<User> getAll()
		{
			this.allUsers = Database.userCollectionObjs.Find(new BsonDocument()).ToList();
			return this.allUsers;
		}

		public void insertOverload(List<User> users)
		{
			if (users.Count > 1)
			{
				Database.userCollectionObjs.InsertMany(users);
				return;
			}
			User user = users[0];
			Database.userCollectionObjs.InsertOne(user);
		}
    
		public void updateMany(Expression<Func<User, bool>> filter, Expression<Func<User, string>> set, string newValue)
		{
			var update = Builders<User>.Update.Set(set, newValue);
			Database.userCollectionObjs.UpdateMany(filter, update);
		}


		public void updateOne(Expression<Func<User, bool>> filter, Expression<Func<User, string>> set, string newValue)
		{
			var update = Builders<User>.Update.Set(set, newValue);
			Database.userCollectionObjs.UpdateOne(filter, update);

		}
		public void deleteOne(Expression<Func<User, bool>> filter)
		{
			Database.userCollectionObjs.FindOneAndDelete(filter);
		}
		public void deleteMany(Expression<Func<User, bool>> filter)
		{
			Database.userCollectionObjs.DeleteMany(filter);  
    }
		
		public void insert(User user)
		{
			Database.userCollectionObjs.InsertOne(user);
		}
    
	}
}
