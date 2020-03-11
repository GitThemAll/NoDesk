using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NoDesk
{
	[BsonIgnoreExtraElements]
	public class Incident : BaseModel

	{
		[BsonRepresentation(BsonType.ObjectId)]
		public string id { get; set; }

		[BsonElement("subject")]
		public string subject { get; set; }

		[BsonElement("user")]
		public string user { get; set; }

		[BsonElement("date")]
		public string date { get; set; }

		[BsonElement("status")]
		public string status { get; set; }

		[BsonElement("summary")]
		public string summary { get; set; }

		[BsonElement("assignedEmployee")]
		public string assignedEmployee { get; set; }

		[BsonElement("dueDate")]
		public string dueDate { get; set; }
	}
}


