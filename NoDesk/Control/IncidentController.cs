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
		private List<Incident> pastIncidents;
		private List<Incident> solvedIncidents;
		private List<Incident> notSolvedIncidents;
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

		public  List<Incident> getSolvedIncidents()
		{
			if (this.allincidents == null)
			{
				this.getAll();
			}

			this.solvedIncidents = this.allincidents.FindAll(x => x.status == IncidentStatus.Solved);
			return this.solvedIncidents;
		}

		public List<Incident> getPastIncidents()
		{
			if (this.allincidents == null)
			{
				this.getAll();
			}

			this.pastIncidents = this.allincidents.FindAll(x => x.dueDate < dateToday);
			return this.pastIncidents;
		}
		public List<Incident> getnotYetSolvedIncidents()
		{
			if (this.allincidents == null)
			{
				this.getAll();
			}

			this.notSolvedIncidents = this.allincidents.FindAll(x => x.status != IncidentStatus.Solved);
			return this.notSolvedIncidents;
		}
		public void updateMany(Expression<Func<Incident, bool>> filter, Expression<Func<Incident, string>> set, string newValue)
		{
			var update = Builders<Incident>.Update.Set(set, newValue);
			Database.incidentCollectionObjs.UpdateMany(filter, update);
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
