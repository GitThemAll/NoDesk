using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace NoDesk
{
	public class IncidentController
	{
		//todo make all methods async
		DateTime dateToday = DateTime.Now;
		private List<Incident> allincidents;
		public  List<Incident> pastIncidents
		{
			get
			{
				if (this.allincidents == null)
				{
					this.getAll();
				}

				return this.allincidents.FindAll(x => x.dueDate < dateToday);
			}
		}
		public List<Incident> solvedIncidents
		{
			get
			{
				if (this.allincidents == null)
				{
					this.getAll();
				}
				return this.allincidents.FindAll(x => x.status == IncidentStatus.Solved);
			}
		}
		public List<Incident> notSolvedIncidents
		{
			get
			{
				if (this.allincidents == null)
				{
					this.getAll();
				}

				return this.allincidents.FindAll(x => x.status != IncidentStatus.Solved);
			}
		}
		public int solvedIncidentsPercentage
		{
			get { return solvedIncidents.Count * 100 / allincidents.Count; }
			private set { }
		}
		public int pastIncidentsPercentage
		{
			get { return pastIncidents.Count * 100 / allincidents.Count; }
			private set { }
		}
		public int notSolvedIncidentsPercentage
		{
			get { return notSolvedIncidents.Count * 100 / allincidents.Count;}
			private set { }
		}
		

		public List<Incident> get(Expression<Func<Incident, bool>> filter)
		{
			
			List<Incident> incidents = Database.incidentCollectionObjs.Find(filter).ToList();
			return incidents;
		}

		public List<Incident> getAll()
		{
			this.allincidents = Database.incidentCollectionObjs.Find(new BsonDocument()).ToList();
			return Database.incidentCollectionObjs.Find(new BsonDocument()).ToList();
		}

		public void insert(List<Incident> incidents)
		{
			
			Database.incidentCollectionObjs.InsertMany(incidents);

		}
		public void insert(Incident incident)
		{
			Database.incidentCollectionObjs.InsertOne(incident);
		}

		

		
		
		public void updateMany(Expression<Func<Incident, bool>> filter, Expression<Func<Incident, string>> set, string newValue)
		{
			var update = Builders<Incident>.Update.Set(set, newValue);
			Database.incidentCollectionObjs.UpdateMany(filter, update);
		}

		public void replace(Expression<Func<Incident, bool>> filter, Incident newValue)
		{
			Database.incidentCollectionObjs.ReplaceOne(filter, newValue);

		}
		public void updateOne(Expression<Func<Incident, bool>> filter, Expression<Func<Incident, string>> set, string newValue)
		{
			var update = Builders<Incident>.Update.Set(set, newValue);
			Database.incidentCollectionObjs.UpdateOne(filter, update);

		}
		public void deleteOne(Expression<Func<Incident, bool>> filter)
		{
			Database.incidentCollectionObjs.FindOneAndDelete(filter);

		}
		public void deleteMany(Expression<Func<Incident, bool>> filter)
		{
			Database.incidentCollectionObjs.DeleteMany(filter);
		}
	}
}
