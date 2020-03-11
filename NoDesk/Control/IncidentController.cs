using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace NoDesk
{
	class IncidentController : IController
	{
		public BaseModel get()
		{
			throw new NotImplementedException();
		}

		public List<BaseModel> getMany()
		{
			throw new NotImplementedException();
		}

		public void insert(BaseModel model)
		{
			throw new NotImplementedException();
		}

		public void insertMany(List<BaseModel> models)
		{
			throw new NotImplementedException();
		}
	}
}
