using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NoDesk
{
	[BsonIgnoreExtraElements]
	class User : BaseModel 
	{
		[BsonRepresentation(BsonType.ObjectId)]
		public string id { get; set; }

		[BsonElement("name")]
		public string name { get; set; }

		[BsonElement("email")]
		public string email { get; set; }

		[BsonElement("password")]
		public string password { get; set; }

	}
}
