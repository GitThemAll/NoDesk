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
	class IncidentController
	{
		DateTime dateToday = DateTime.Now;
		private List<Incident> incidents;
		private List<Incident> pastIncidents;
		private List<Incident> solvedIncidents;
		private List<Incident> notSolvedIncidents;
		public int solvedIncidentsPercentage
		{
			get { return solvedIncidents.Count * 100 / incidents.Count; }
			private set { }
		}
		public int pastIncidentsPercentage
		{
			get { return pastIncidents.Count * 100 / incidents.Count; }
			private set { }
		}
		public int notSolvedIncidentsPercentage
		{
			get { return notSolvedIncidents.Count * 100 / incidents.Count;}
			private set { }
		}
		public List<Incident> get(Expression<Func<Incident, bool>> filter)
		{
			List<Incident> incidents = Database.incidentCollectionObjs.Find(filter).ToList();
			return incidents;
		}

		public List<Incident> getAll()
		{
			List<Incident> incidents = Database.incidentCollectionObjs.Find(new BsonDocument()).ToList();
			this.incidents = incidents;
			return incidents;
		}

		public void insert(List<Incident> incidents)
		{
			if (incidents.Count > 1)
			{
				Database.incidentCollectionObjs.InsertMany(incidents);
				return;

			}
			Incident incident = incidents[0];
			Database.incidentCollectionObjs.InsertOne(incident);

		}

		internal List<Incident> getSolvedIncidents()
		{
			if (this.incidents == null)
			{
				this.getAll();
			}

			this.solvedIncidents = this.incidents.FindAll(x => x.status == "Solved");
			return this.solvedIncidents;
		}

		public List<Incident> getPastIncidents()
		{
			if (this.incidents == null)
			{
				this.getAll();
			}

			this.pastIncidents = this.incidents.FindAll(x => x.dueDate < dateToday);
			return this.pastIncidents;
		}
		public List<Incident> getnotYetSolvedIncidents()
		{
			if (this.incidents == null)
			{
				this.getAll();
			}

			this.notSolvedIncidents = this.incidents.FindAll(x => x.status != "Solved");
			return this.notSolvedIncidents;
		}
	}
}
