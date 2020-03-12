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
		public List<BaseModel> get(string searchExpression)
		{
			List<Incident> users = Database.incidentCollectionObjs.Find(searchExpression).ToList();
			List<BaseModel> baseModels = new List<BaseModel>();
			foreach (Incident incident in users)
			{

				baseModels.Add(incident);
			}
			return baseModels;
		}

		public List<BaseModel> getAll()
		{
			List<BaseModel> baseModels = new List<BaseModel>();
			var incidents = Database.incidentCollectionObjs.Find(new BsonDocument()).ToList();
			foreach (Incident user in incidents)
			{

				baseModels.Add(user);
			}
			return baseModels;
		}

		public void insert(List<BaseModel> models)
		{
			List<Incident> incidents = new List<Incident>();
			foreach (Incident model in models)
			{
				incidents.Add(model);
			}
			Database.incidentCollectionObjs.InsertMany(incidents);
		}
	}
}
