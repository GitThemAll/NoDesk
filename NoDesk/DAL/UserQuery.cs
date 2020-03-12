using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;


namespace NoDesk
{
    class UserQuery
    {
        
        public UserQuery()
        {

        }
        public User GetLogin(string email, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("email", email) & Builders<BsonDocument>.Filter.Eq("password", password);
            var document = Database.userCollection.Find(filter).First();
            User user = new User()
            {
                name = document.GetValue(1).ToString(),
                email = document.GetValue(2).ToString()
            };
            return user;
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = Database.userCollection.Find(filter).ToList();
            foreach (var document in documents)
            {
                User user = new User();
                user.name = document.GetValue(0).ToString();
                user.password = document.GetValue(1).ToString();
            }
       
            return users;
        }

    }
}
