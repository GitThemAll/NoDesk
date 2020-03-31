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
		public Incident(string subject, string user, string summary, DateTime dueDate)
		{
			this.subject = subject;
			this.user = user;
			this.summary = summary;
			this.dueDate = dueDate;
			this.date= DateTime.Now;
			this.status = IncidentStatus.NotSolved;
		}

		public void assignUser(User employee)
		{
			this.assignedEmployee = user;
		}

		[BsonRepresentation(BsonType.ObjectId)]
		public ObjectId id { get; set; }

		[BsonElement("subject")]
		public string subject { get; set; }

		[BsonElement("user")]
		public string user { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
		[BsonElement("date")]
		public DateTime date { get; set; }

		[BsonElement("status")]
		public IncidentStatus status { get; set; }

		[BsonElement("summary")]
		public string summary { get; set; }

		[BsonElement("assignedEmployee")]
		public string assignedEmployee { get; set; }

		[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
		[BsonElement("dueDate")]
		public DateTime dueDate { get; set; }
	}
}


