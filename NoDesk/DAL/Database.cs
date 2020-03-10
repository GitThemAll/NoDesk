using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NoDesk
{
	class Database
	{
		MongoClient client;
		public Database()
		{
			this.client = new MongoClient(string.Format("mongodb+srv://{0}:{1}@{2}/test?retryWrites=true&w=majority",Settings.username, Settings.password, Settings.clusterAddress));


		}

	}
}
