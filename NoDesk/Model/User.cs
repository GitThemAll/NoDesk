using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NoDesk
{
	[BsonIgnoreExtraElements]
	public class User : BaseModel 
	{
        public User()
        {
        }

    

        public User(string firstname, string lastname, string email, string password)
		{
			this.firstname = firstname;
			this.lastname = lastname;
			this.email = email;
			this.password = password;
		}

		[BsonRepresentation(BsonType.ObjectId)]
		public ObjectId id { get; set; }

		[BsonElement("firstname")]
		public string firstname { get; set; }


		[BsonElement("lastname")]
		public string lastname { get; set; }


		[BsonElement("email")]
		public string email { get; set; }

		[BsonElement("password")]
		public string password { get; set; }

		[JsonConverter(typeof(StringEnumConverter))]  // JSON.Net
		[BsonRepresentation(BsonType.String)]         // Mongo
		public UserType type { get; set; }
		public override string ToString()
		{
			return this.firstname + " " + this.lastname;
		}
	}
}
