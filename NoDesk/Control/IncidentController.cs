using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace NoDesk
{
	class IncidentController : IController
	{
		public BaseModel get()
		{
			throw new NotImplementedException();
		}

		public List<BaseModel> getMany(List<BaseModel> documents ,SearchMethod searchMethod )
		{
			throw new NotImplementedException();
		}

		public List<BaseModel> getAll()
		{
			List<BaseModel> incidents = new List<BaseModel>();
			var documents = Database.incidentCollection.Find(new BsonDocument()).ToList();
			foreach (var document in documents)
			{
				User incident = BsonSerializer.Deserialize<User>(document);
				incidents.Add(incident);
			}
			return incidents;
		}


		public void insert(List<BaseModel> documents)
		{
			throw new NotImplementedException();
		}
	}
}
